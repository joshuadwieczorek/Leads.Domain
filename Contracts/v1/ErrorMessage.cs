using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    public class ErrorMessage
    {
        [JsonProperty("field")]
        public string Field { get; init; }

        [JsonProperty("message")]
        public string Message { get; init; }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="field"></param>
        /// <param name="message"></param>
        public ErrorMessage(string field, string message)
        {
            Field = field;
            Message = message;
        }
    }
}