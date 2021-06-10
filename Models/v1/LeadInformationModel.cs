using Newtonsoft.Json;

namespace Leads.Domain.Models.v1
{
    public class LeadInformationModel
    {
        [JsonProperty("fullName")]
        public string FullName { get; set; }

        [JsonProperty("firstName")]
        public string FirstName { get; set; }

        [JsonProperty("lastName")]
        public string LastName { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("cellPhone")]
        public string CellPhone { get; set; }

        [JsonProperty("homePhone")]
        public string HomePhone { get; set; }

        [JsonProperty("workPhone")]
        public string WorkPhone { get; set; }

        [JsonProperty("address1")]
        public string Address1 { get; set; }

        [JsonProperty("address2")]
        public string Address2 { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }

        [JsonProperty("referrer")]
        public string Referrer { get; set; }

        [JsonProperty("lead_type")]
        public string LeadType { get; set; }

        [JsonProperty("vehicleYear")]
        public int? VehicleYear { get; set; }

        [JsonProperty("vehicleMake")]
        public string VehicleMake { get; set; }

        [JsonProperty("vehicleModel")]
        public string VehicleModel { get; set; }

        [JsonProperty("vehicleTrim")]
        public string VehicleTrim { get; set; }

        [JsonProperty("vehicleVdpUrl")]
        public string VehicleVdpUrl { get; set; }

        [JsonProperty("vehicleCondition")]
        public string VehicleCondition { get; set; }

        [JsonProperty("dealerName")]
        public string DealerName { get; set; }
    }
}