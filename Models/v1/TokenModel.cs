using System;
using Newtonsoft.Json;

namespace Leads.Domain.Models.v1
{
    public class TokenModel : BaseModel
    {
        [JsonProperty("tokenId")]
        public Guid? TokenId { get; set; }

        [JsonProperty("rooftopId")]
        public int? RooftopId { get; set; }

        [JsonProperty("expiresAt")]
        public DateTime? ExpiresAt { get; set; }

        [JsonProperty("isRolling")]
        public bool IsRolling { get; set; }

        [JsonProperty("isExpired")]
        public bool IsExpired
            => ExpiresAt.HasValue && DateTime.Now >= ExpiresAt;

        [JsonProperty("leadProvider")]
        public LeadProviderModel LeadProvider { get; set; }

        [JsonProperty("configuration")]
        public TokenConfigurationModel Configuration { get; set; }        
    }
}