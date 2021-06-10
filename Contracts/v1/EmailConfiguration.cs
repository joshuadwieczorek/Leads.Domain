using Newtonsoft.Json;
using System.Net.Mail;

namespace Leads.Domain.Contracts.v1
{
    public class EmailConfiguration
    {
        [JsonProperty("smtpHost")]
        public string SmtpHost { get; init; }

        [JsonProperty("smtpUser")]
        public string SmtpUser { get; init; }

        [JsonProperty("smtpPassword")]
        public string SmtpPassword { get; init; }

        [JsonProperty("fromName")]
        public string FromName { get; init; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; init; }

        [JsonProperty("port")]
        public int? Port { get; init; }

        [JsonProperty("enableSsl")]
        public bool? EnableSsl { get; init; }

        [JsonProperty("deliveryMethod")]
        public SmtpDeliveryMethod? DeliveryMethod { get; set; }

        [JsonProperty("pickupDirectoryLocation")]
        public string PickupDirectoryLocation { get; set; }

        [JsonProperty("isTesting")]
        public bool IsTesting { get; set; }

        [JsonProperty("testingEmail")]
        public string TestingEmail { get; set; }
    }
}