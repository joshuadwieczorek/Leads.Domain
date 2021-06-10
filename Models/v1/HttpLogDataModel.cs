using Newtonsoft.Json;

namespace Leads.Domain.Models.v1
{
    public class HttpLogDataModel
    {
        [JsonProperty("logDataType")]
        public Enums.HttpLogDataType LogDataType { get; set; }

        [JsonProperty("data")]
        public string Data { get; set; }
    }
}