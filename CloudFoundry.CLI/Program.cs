using System;
using CloudFoundry.CloudController.Common.Config;
using CloudFoundry.CloudController.V2.Client;
using CloudFoundry.UAA;

namespace CloudFoundry.CLI
{
    class Program
    {
		static void Main(string[] args)
		{
			
			var config = Config.Load();
			AuthenticationContext context = null;

			var client = new CloudFoundryClient(
				new Uri(config.Target), 
				new System.Threading.CancellationToken(),
				null,
				config.SSLDisabled,
				new Uri(config.AuthorizationEndpoint + "/oauth/token")
			);

			CloudCredentials credentials = new CloudCredentials()
			{
				User = "admin",
				Password = "admin"
			};

			try
			{
				context = client.Login(credentials).Result;
				Console.WriteLine("RefreshToken {0}", context.Token.RefreshToken);
				var info = client.Info.GetInfo().Result;
				Console.WriteLine(info);
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex.ToString());
			}
        }
    }
}
