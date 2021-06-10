namespace Leads.Domain.Contracts.v1
{
    public partial class SmartCouponOptionModels
    {
        public class Download
        {
            public string btn { get; set; }
            public string msg { get; set; }
            public string guide_mobile { get; set; }
            public string guide_desktop { get; set; }
        }
    }
}