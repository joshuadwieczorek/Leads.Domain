using System.Collections.Generic;
using Newtonsoft.Json;

namespace Leads.Domain.Contracts.v1
{
    /// <summary>
    /// Api wrapper without type.
    /// </summary>
    public class ApiWrapper
    {
        [JsonProperty("statusCode")]
        public int? Status { get; init; }

        [JsonProperty("message")]
        public string Message { get; init; }

        [JsonProperty("errors", NullValueHandling = NullValueHandling.Ignore)]
        public IEnumerable<ErrorMessage> Errors { get; init; }


        /// <summary>
        /// Empty constructor.
        /// </summary>
        public ApiWrapper() {}


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="errors"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        public ApiWrapper(List<ErrorMessage> errors, string message = "failed", int? status = 422)
        {
            Errors = errors;
            Message = message;
            Status = status;
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        public ApiWrapper(ErrorMessage error, string message = "failed", int? status = 422)
        {
            Errors = new List<ErrorMessage>() { error };
            Message = message;
            Status = status;
        }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="error"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        public ApiWrapper(string error, string message = "failed", int? status = 422)
        {
            Errors = new List<ErrorMessage>() { new ErrorMessage("body", error) };
            Message = message;
            Status = status;
        }
    }


    /// <summary>
    /// Api wrapper with type.
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class ApiWrapper<T> : ApiWrapper
    {
        [JsonProperty("data")]
        public T Data { get; init; }


        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="data"></param>
        /// <param name="message"></param>
        /// <param name="status"></param>
        public ApiWrapper(T data, string message = "success", int? status = 200)
        {
            Data = data;
            Message = message;
            Status = status;
        }        
    }
}