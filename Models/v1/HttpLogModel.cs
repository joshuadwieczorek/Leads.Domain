using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace Leads.Domain.Models.v1
{
    public class HttpLogModel
    {
        [JsonProperty("logId")]
        public long? LogId { get; set; }

        [JsonProperty("ipAddress")]
        public string IpAddress { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonProperty("statusCode")]
        public int StatusCode { get; set; }

        [JsonProperty("httpMethod"), JsonConverter(typeof(StringEnumConverter))]
        public Enums.HttpMethod HttpMethod { get; set; }

        [JsonProperty("startTime")]
        public DateTime? StartTime { get; set; }

        [JsonProperty("endTime")]
        public DateTime? EndTime { get; set; }

        [JsonProperty("createdBy")]
        public string CreatedBy { get; set; }

        [JsonProperty("createdAt")]
        public DateTime? CreatedAt { get; set; }

        [JsonProperty("updatedBy")]
        public string UpdatedBy { get; set; }

        [JsonProperty("updatedAt")]
        public DateTime? UpdatedAt { get; set; }

        [JsonProperty("requestHeaders")]
        public HttpLogDataModel RequestHeaders { get; private set; }

        [JsonProperty("requestBody")]
        public HttpLogDataModel RequestBody { get; private set; }

        [JsonProperty("responseBody")]
        public HttpLogDataModel ResponseBody { get; private set; }


        /// <summary>
        /// Constructor.
        /// </summary>
        public HttpLogModel()
        {
            RequestHeaders = new HttpLogDataModel();
            RequestBody = new HttpLogDataModel();
            ResponseBody = new HttpLogDataModel();
        }


        /// <summary>
        /// Set request headers.
        /// </summary>
        /// <param name="headers"></param>
        public void SetRequestHeaders(String headers)
            => RequestHeaders = new HttpLogDataModel
            {
                Data = headers ?? String.Empty,
                LogDataType = Enums.HttpLogDataType.RequestHeaders
            };


        /// <summary>
        /// Set request body.
        /// </summary>
        /// <param name="bodyString"></param>
        public void SetRequestBody(String bodyString)
            => RequestBody = new HttpLogDataModel
            {
                Data = bodyString ?? String.Empty,
                LogDataType = Enums.HttpLogDataType.RequestBody
            };


        /// <summary>
        /// Set response body.
        /// </summary>
        /// <param name="result"></param>
        public void SetResponseBody(String result)
             => ResponseBody = new HttpLogDataModel
             {
                 Data = result ?? String.Empty,
                 LogDataType = Enums.HttpLogDataType.ResponseBody
             };
    }
}