namespace Leads.Domain.Models.v1
{
    public class LeadProviderModel : BaseModel
    {
        public int? LeadProviderId { get; init; }
        public string Name { get; set; }      
    }
}