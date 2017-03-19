namespace CloudFoundry.CloudController.Common.Config
{
	using Newtonsoft.Json;

	public class OrganizationFields
    {
		[JsonProperty(PropertyName = "GUID")]
        public string GUID { get; set; }

		[JsonProperty(PropertyName = "Name")]
        public string Name { get; set; }

		[JsonProperty(PropertyName = "QuotaDefinition")]
        public QuotaDefinition QuotaDefinition { get; set; }
    }
}
