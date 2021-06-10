using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Leads.Domain.Contracts.v1
{
    public partial class SmartCouponOptionModels
    {
            public string coupon_template { get; set; }
            public string campaign_name { get; set; }
            public string disclaimer_link { get; set; }
            public string disclaimer_text { get; set; }
            public string cta_text { get; set; }
            public Download download { get; set; }
            public Run_End run_end { get; set; }
            public Headline headline { get; set; }
            public Headline headline_2 { get; set; }
            public Headline headline_3 { get; set; }
            public string? image { get; set; }
            public string? link_url { get; set; }
            public Dealer dealer { get; set; }

            public class Dealer
            {
                public int id { get; set; }
                public string name { get; set; }
                public string logo { get; set; }
            }
    }
}
