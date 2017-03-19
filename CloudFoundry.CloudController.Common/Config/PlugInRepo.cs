namespace CloudFoundry.CloudController.Common.Config
{
	using Newtonsoft.Json;
 
	public class PlugInRepo
    {
		[JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

		[JsonProperty(PropertyName = "URL")]
        public string URL { get; set; }
    }
}
