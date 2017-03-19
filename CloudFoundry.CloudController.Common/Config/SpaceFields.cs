namespace CloudFoundry.CloudController.Common.Config
{
	using Newtonsoft.Json;
 
	public class SpaceFields
    {
		[JsonProperty(PropertyName = "GUID")]
        public string GUID { get; set; }

		[JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }
		
		[JsonProperty(PropertyName = "AllowSSH")]
        public bool AllowSSH { get; set; }
    }
}
