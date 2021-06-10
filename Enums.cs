using System.Runtime.Serialization;

namespace Leads.Domain
{
    public class Enums
    {
        public enum DeliveryAction : uint
        {
            [EnumMember(Value = "None")]
            None = 0,

            [EnumMember(Value = "Email")]
            Email = 1,

            [EnumMember(Value = "Adf")]
            Adf = 2,

            [EnumMember(Value = "DotDigital")]
            DotDigital = 3,
        }


        public enum HttpLogDataType
        {
            RequestHeaders = 1,
            RequestBody = 2,
            ResponseBody = 3
        }


        public enum HttpMethod
        {
            UNKNOWN = 1,
            GET = 2,
            POST = 3,
            PUT = 4,
            PATCH = 5,
            DELETE = 6
        }
    }
}