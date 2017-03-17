namespace CloudFoundry.UAA.Authentication
{
    using System;
    using System.Globalization;
    using System.Threading.Tasks;
    using CloudFoundry.CloudController.Common.Http;
    using CloudFoundry.UAA;
    using CloudFoundry.UAA.Exceptions;
    using System.Collections.Generic;
    using System.Threading;
    using System.Runtime.CompilerServices;
    using System.Diagnostics;

    // using Thinktecture.IdentityModel.Client;

    internal class AuthenticationImpl : IAuthentication
    {
        // CF defaults
        private string oauthClient = "cf";

        private string oauthSecret = string.Empty;
        private Uri oauthTarget;
        private Uri httpProxy;
        private bool skipCertificateValidation;
        private Token token = new Token();

        internal AuthenticationImpl(Uri authenticationUri)
            : this(authenticationUri, null)
        {
        }

        internal AuthenticationImpl(Uri authenticationUri, Uri httpProxy)
            : this(authenticationUri, httpProxy, false)
        {
        }

        internal AuthenticationImpl(Uri authenticationUri, Uri httpProxy, bool skipCertificateValidation)
        {
            this.oauthTarget = authenticationUri;
            this.httpProxy = httpProxy;
            this.skipCertificateValidation = skipCertificateValidation;
        }

        public Uri OAuthUri
        {
            get
            {
                return this.oauthTarget;
            }
        }

        public async Task<Token> Authenticate(CloudCredentials credentials)
        {
            if (credentials == null)
            {
                throw new ArgumentNullException("credentials");
            }

            using (var httpClientHandler = new AcceptHeaderOverrideHttpClientHandler())
            {
                if (this.httpProxy != null)
                {
                    httpClientHandler.Proxy = new SimpleProxy(this.httpProxy);
                }

                httpClientHandler.OverrideAcceptHeader = "application/json";
                httpClientHandler.SkipCertificateValidation = this.skipCertificateValidation;

                var client = new OAuth2Client(this.oauthTarget, this.oauthClient, this.oauthSecret, httpClientHandler);

                this.token.Expires = DateTime.Now;

                var tokenResponse = await client.RequestResourceOwnerPasswordAsync(credentials.User, credentials.Password);

                CheckTokenResponseError(tokenResponse);

                this.token.AccessToken = tokenResponse.AccessToken;
                this.token.RefreshToken = tokenResponse.RefreshToken;
                this.token.Expires = this.token.Expires.AddSeconds(tokenResponse.ExpiresIn);
            }

            return this.token;
        }

        public async Task<Token> Authenticate(string refreshToken)
        {
            this.token.Expires = DateTime.Now;
            var tokenResponse = await this.RefreshToken(refreshToken);
            this.token.Expires = this.token.Expires.AddSeconds(tokenResponse.ExpiresIn);
            this.token.AccessToken = tokenResponse.AccessToken;
            this.token.RefreshToken = tokenResponse.RefreshToken;

            return this.token;
        }

        public async Task<Token> GetToken()
        {
            if (this.token == null)
            {
                return this.token;
            }

            // Check to see if token is about to expire
            if (this.token.Expires < DateTime.Now)
            {
                this.token.Expires = DateTime.Now;
                var tokenResponse = await this.RefreshToken(this.token.RefreshToken);

                this.token.AccessToken = tokenResponse.AccessToken;
                this.token.RefreshToken = tokenResponse.RefreshToken;
                this.token.Expires = this.token.Expires.AddSeconds(tokenResponse.ExpiresIn);
            }

            return this.token;
        }

        private static void CheckTokenResponseError(TokenResponse tokenResponse)
        {
            if (tokenResponse.IsHttpError)
            {
                throw new AuthenticationException(
                    string.Format(
                    CultureInfo.InvariantCulture,
                    "Unable to connect to target. HTTP Error: {0}. HTTP Error Code {1}",
                    tokenResponse.HttpErrorReason,
                    tokenResponse.HttpErrorStatusCode));
            }

            if (tokenResponse.IsError)
            {
                throw new AuthenticationException(
                    string.Format(
                    CultureInfo.InvariantCulture,
                    "Unable to connect to target. Error message: {0}",
                    tokenResponse.Error));
            }
        }

        private async Task<TokenResponse> RefreshToken(string refreshToken)
        {
            using (var httpClientHandler = new AcceptHeaderOverrideHttpClientHandler())
            {
                if (this.httpProxy != null)
                {
                    httpClientHandler.Proxy = new SimpleProxy(this.httpProxy);
                }

                httpClientHandler.OverrideAcceptHeader = "application/json";
                httpClientHandler.SkipCertificateValidation = this.skipCertificateValidation;

                var client = new OAuth2Client(this.oauthTarget, this.oauthClient, this.oauthSecret, httpClientHandler);
                var tokenResponse = await client.RequestRefreshTokenAsync(refreshToken);
                CheckTokenResponseError(tokenResponse);
                return tokenResponse;
            }
        }
    }

    public class TokenResponse
    {
        public TokenResponse(string raw) { }
        public TokenResponse(System.Net.HttpStatusCode statusCode, string reason) { }

        public string Raw { get; protected set; }
        public Newtonsoft.Json.Linq.JObject Json { get; protected set; }
        public bool IsHttpError { get; }
        public System.Net.HttpStatusCode HttpErrorStatusCode { get; }
        public string HttpErrorReason { get; }
        public string AccessToken { get; }
        public string IdentityToken { get; }
        public string Error { get; }
        public bool IsError { get; }
        public long ExpiresIn { get; }
        public string TokenType { get; }
        public string RefreshToken { get; }

    }

    public class OAuth2Client
    {
        protected System.Net.Http.HttpClient _client;
        protected ClientAuthenticationStyle _authenticationStyle;
        protected Uri _address;
        protected string _clientId;
        protected string _clientSecret;

        public OAuth2Client(Uri address) { }
        public OAuth2Client(Uri address, System.Net.Http.HttpMessageHandler innerHttpClientHandler) { }
        public OAuth2Client(Uri address, string clientId, string clientSecret, ClientAuthenticationStyle style = ClientAuthenticationStyle.BasicAuthentication) { }
        public OAuth2Client(Uri address, string clientId, string clientSecret, System.Net.Http.HttpMessageHandler innerHttpClientHandler, ClientAuthenticationStyle style = ClientAuthenticationStyle.BasicAuthentication) { }

        public TimeSpan Timeout { get;  set; }

        public static string CreateAuthorizeUrl(Uri endpoint, Dictionary<string, string> values) { return null; }
        public string CreateAuthorizeUrl(string clientId, string responseType, string scope = null, string redirectUri = null, string state = null, string nonce = null, string loginHint = null, string acrValues = null, string responseMode = null, Dictionary<string, string> additionalValues = null) { return null; }
        public string CreateCodeFlowUrl(string clientId, string scope = null, string redirectUri = null, string state = null, string nonce = null, string loginHint = null, string acrValues = null, Dictionary<string, string> additionalValues = null) { return null; }
        public string CreateImplicitFlowUrl(string clientId, string scope = null, string redirectUri = null, string state = null, string nonce = null, string loginHint = null, string acrValues = null, Dictionary<string, string> additionalValues = null) { return null; }
        public Task<TokenResponse> RequestAssertionAsync(string assertionType, string assertion, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        //[AsyncStateMachine(typeof(< RequestAsync > d__a))]
        [DebuggerStepThrough]
        public Task<TokenResponse> RequestAsync(Dictionary<string, string> form, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestAuthorizationCodeAsync(string code, string redirectUri, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestClientCredentialsAsync(string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestCustomAsync(Dictionary<string, string> values, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestCustomGrantAsync(string grantType, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestRefreshTokenAsync(string refreshToken, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }
        public Task<TokenResponse> RequestResourceOwnerPasswordAsync(string userName, string password, string scope = null, Dictionary<string, string> additionalValues = null, CancellationToken cancellationToken = default(CancellationToken)) { return null; }

        public enum ClientAuthenticationStyle
        {
            BasicAuthentication = 0,
            PostValues = 1,
            None = 2
        }
    }
}
