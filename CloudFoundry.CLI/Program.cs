using System;
using CloudFoundry.CloudController.Common.Config;
                  
namespace CloudFoundry.CLI
{
    class Program
    {
        static void Main(string[] args)
        {
			var config = Config.Load();
			Console.WriteLine("APIVersion {0}", config.APIVersion);
			config.SSLDisabled = !config.SSLDisabled;
			config.Save();
        }
    }
}
