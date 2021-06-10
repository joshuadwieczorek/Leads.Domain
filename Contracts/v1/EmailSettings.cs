using System.Collections.Generic;
using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    public class EmailSettings
    {
        [JsonProperty("subject")]
        public string Subject { get; set; }

        [JsonProperty("template")]
        public string Template { get; set; }

        [JsonProperty("fromName")]
        public string FromName { get; set; }

        [JsonProperty("fromEmail")]
        public string FromEmail { get; set; }

        [JsonProperty("isHtml")]
        public bool IsHtml { get; set; }

        [JsonProperty("recipients")]
        public IEnumerable<string> Recipients { get; set; }

        public string Body { get; set; } 
    }
}