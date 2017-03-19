namespace CloudFoundry.CloudController.Common.Config
{
	using System;
	using System.Collections.Generic;
	using System.IO;
	using Newtonsoft.Json;

	public class Config
    {
		const string configDirectory = ".cf";
		const string configFilename = "config.json";

		[JsonIgnore]
		public FileInfo ConfigFile { get; private set; }

		[JsonProperty(PropertyName = "ConfigVersion")]
		public int ConfigVersion { get; set; }

		[JsonProperty(PropertyName = "Target")]
        public string Target { get; set; }

		[JsonProperty(PropertyName = "APIVersion")]
        public string APIVersion { get; set; }

		[JsonProperty(PropertyName = "AuthorizationEndpoint")]
        public string AuthorizationEndpoint { get; set; }

		[JsonProperty(PropertyName = "DopplerEndPoint")]
        public string DopplerEndPoint { get; set; }

		[JsonProperty(PropertyName = "UaaEndpoint")]
        public string UaaEndpoint { get; set; }

		[JsonProperty(PropertyName = "RoutingAPIEndpoint")]
        public string RoutingAPIEndpoint { get; set; }

		[JsonProperty(PropertyName = "AccessToken")]
        public string AccessToken { get; set; }

		[JsonProperty(PropertyName = "UAAOAuthClient")]
        public string UAAOAuthClient { get; set; }

		[JsonProperty(PropertyName = "UAAOAuthClientSecret")]
        public string UAAOAuthClientSecret { get; set; }

		[JsonProperty(PropertyName = "SSHOAuthClient")]
        public string SSHOAuthClient { get; set; }

		[JsonProperty(PropertyName = "RefreshToken")]
        public string RefreshToken { get; set; }

		[JsonProperty(PropertyName = "OrganizationFields")]
        public OrganizationFields OrganizationFields { get; set; }

		[JsonProperty(PropertyName = "SpaceFields")]
        public SpaceFields SpaceFields { get; set; }

		[JsonProperty(PropertyName = "SSLDisabled")]
        public bool SSLDisabled { get; set; }

		[JsonProperty(PropertyName = "AsyncTimeout")]
        public int AsyncTimeout { get; set; }

		[JsonProperty(PropertyName = "Trace")]
        public string Trace { get; set; }

		[JsonProperty(PropertyName = "ColorEnabled")]
        public string ColorEnabled { get; set; }

		[JsonProperty(PropertyName = "Locale")]
        public string Locale { get; set; }

		[JsonProperty(PropertyName = "PluginRepos")]
        public List<PlugInRepo> PluginRepos { get; set; }

		[JsonProperty(PropertyName = "MinCLIVersion")]
        public string MinCLIVersion { get; set; }

		[JsonProperty(PropertyName = "MinRecommendedCLIVersion")]
        public string MinRecommendedCLIVersion { get; set; }

		public static Config Load()
		{
			return Load(new FileInfo(Path.Combine(GetHomeDirectory(), configDirectory, configFilename)));
		}

		public static Config Load(FileInfo configFile)
		{
			if (!configFile.Exists)
			{
				throw new FileNotFoundException(configFile.FullName);
			}

			using (var file = configFile.OpenText())
			{
				JsonSerializer serializer = new JsonSerializer();
				var config = (Config)serializer.Deserialize(file, typeof(Config));
				config.ConfigFile = configFile;
				return config;
			}
		}

		public void Save()
		{
			using (var file = ConfigFile.CreateText())
			{
				
				JsonSerializer serializer = new JsonSerializer();
				serializer.Formatting = Formatting.Indented;
				serializer.Serialize(file, this);
				file.Flush();
			}
		}

		private static string GetHomeDirectory()
		{
			string homeDrive = Environment.GetEnvironmentVariable("HOMEDRIVE");
			string homePath = Environment.GetEnvironmentVariable("HOMEPATH");
			string homeUnix = Environment.GetEnvironmentVariable("HOME");

			if ((!string.IsNullOrEmpty(homeDrive)) && (!string.IsNullOrEmpty(homePath)))
			{
				return Path.Combine(homeDrive, homePath);
			}
			else if (!string.IsNullOrEmpty(homeUnix))
			{
				return homeUnix;
			}
			else
			{
				return null;
			}
		}
    }
}
