using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    public class AdfSettings
    {
        [JsonProperty("sourceName")]
        public string SourceName { get; set; }

        [JsonProperty("vendorName")]
        public string VendorName { get; set; }

        [JsonProperty("contactName")]
        public string ContactName { get; set; }

        [JsonProperty("providerService")]
        public string ProviderService { get; set; }

        [JsonProperty("providerUrl")]
        public string ProviderUrl { get; set; }

        [JsonProperty("providerEmail")]
        public string ProviderEmail { get; set; }
    }
}