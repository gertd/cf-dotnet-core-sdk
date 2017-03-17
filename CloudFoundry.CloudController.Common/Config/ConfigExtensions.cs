namespace CloudFoundry.CloudController.Common.Config
{
    using Newtonsoft.Json;
    using System.IO;

    public static class ConfigExtensions
    {
        public static Config LoadConfig()
        {
            using (StreamReader file = File.OpenText(@"c:\users\gertd\.cf\config.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                Config config = (Config)serializer.Deserialize(file, typeof(Config));
                return config;
            }
        }
    }
}
