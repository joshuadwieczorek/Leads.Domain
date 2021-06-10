using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    public class DotDigitalSettings
    {
        [JsonProperty("baseUrl")]
        public string BaseUrl { get; init; }

        [JsonProperty("apiUser")]
        public string ApiUser { get; init; }

        [JsonProperty("apiPassword")]
        public string ApiPassword { get; init; }

        [JsonProperty("addressBookName")]
        public string AddressBookName { get; init; }

        [JsonProperty("addressBookId")]
        public long AddressBookId { get; init; }
    }
}