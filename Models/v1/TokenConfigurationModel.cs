using System.Collections.Generic;
using Newtonsoft.Json;
using Leads.Domain.Contracts.v1;
using Newtonsoft.Json.Converters;

namespace Leads.Domain.Models.v1
{
    public class TokenConfigurationModel
    {
        //[JsonProperty("deliveryActions", ItemConverterType = typeof(StringEnumConverter))]
        [JsonProperty("deliveryActions")]
        public IList<Enums.DeliveryAction> DeliveryActions { get; set; }

        [JsonProperty("emailConfiguration")]
        public EmailConfiguration EmailConfiguration { get; set; }

        [JsonProperty("adfSettings")]
        public AdfSettings AdfSettings { get; set; }

        [JsonProperty("dotDigitalSettings")]
        public DotDigitalSettings DotDigitalSettings { get; set; }

        [JsonProperty("emailSettings")]
        public Dictionary<Enums.DeliveryAction, EmailSettings> EmailSettings { get; set; }
    }
}