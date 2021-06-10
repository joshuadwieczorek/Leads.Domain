using Newtonsoft.Json;

namespace Leads.Domain.Models.v1
{
    public class QueueModel
    {
        [JsonProperty("token")]
        public TokenModel Token { get; set; }

        [JsonProperty("leadInformation")]
        public LeadInformationModel LeadInformation { get; set; }
    }
}