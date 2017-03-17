using Newtonsoft.Json;

namespace CloudFoundry.CloudController.Common.Config
{
    public class QuotaDefinition
    {
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        [JsonProperty(PropertyName = "memory_limit")]
        public int MemoryLimit { get; set; }

        [JsonProperty(PropertyName = "instance_memory_limit")]
        public int InstanceMemoryLimit { get; set; }

        [JsonProperty(PropertyName = "total_routes")]
        public int TotalRoutes { get; set; }

        [JsonProperty(PropertyName = "total_services")]
        public int TotalServices { get; set; }

        [JsonProperty(PropertyName = "non_basic_services_allowed")]
        public bool NonBasicServicesAllowed { get; set; }

        [JsonProperty(PropertyName = "app_instance_limit")]
        public int AppInstanceLimit { get; set; }
    }
}
