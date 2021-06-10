using System.Collections.Generic;
using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    public class SmartCoupon
    {
        [JsonProperty("fname")]
        public List<string> FirstName { get; set; }

        [JsonProperty("lname")]
        public List<string> LastName { get; set; }

        [JsonProperty("phone")]
        public List<string> PhoneNumber { get; set; }

        [JsonProperty("email")]
        public List<string> EmailAddress { get; set; }

        [JsonProperty("campaign_name")]
        public List<string> Campaign { get; set; }

        [JsonProperty("recipient_leads")]
        public List<string> LeadDestination { get; set; }

        [JsonProperty("recipient_notification")]
        public List<string> NotificationDestination { get; set; }

        [JsonProperty("lead_type")]
        public List<string> LeadType { get; set; }

        [JsonProperty("dealer_name")]
        public List<string> DealerName { get; set; }

        [JsonProperty("referring_page")]
        public List<string> ReferringPage { get; set; }

        [JsonProperty("offer")]
        public List<string> Offer { get; set; } = new List<string>();

        [JsonProperty("Options")]
        public SmartCouponOptionModels Options { get; set; }
    }
}
