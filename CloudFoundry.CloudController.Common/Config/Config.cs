namespace CloudFoundry.CloudController.Common.Config
{
    using System.Collections.Generic;

    public class Config
    {
        public int ConfigVersion { get; set; }
        public string Target { get; set; }
        public string APIVersion { get; set; }
        public string AuthorizationEndpoint { get; set; }
        public string DopplerEndPoint { get; set; }
        public string UaaEndpoint { get; set; }
        public string RoutingAPIEndpoint { get; set; }
        public string AccessToken { get; set; }
        public string UAAOAuthClient { get; set; }
        public string UAAOAuthClientSecret { get; set; }
        public string SSHOAuthClient { get; set; }
        public string RefreshToken { get; set; }
        public OrganizationFields OrganizationFields { get; set; }
        public SpaceFields SpaceFields { get; set; }
        public bool SSLDisabled { get; set; }
        public int AsyncTimeout { get; set; }
        public string Trace { get; set; }
        public string ColorEnabled { get; set; }
        public string Locale { get; set; }
        public List<PlugInRepo> PluginRepos { get; set; }
        public string MinCLIVersion { get; set; }
        public string MinRecommendedCLIVersion { get; set; }
    }
}
