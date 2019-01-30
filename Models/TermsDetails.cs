using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class TermsDetails
    {
        public long Termid { get; set; }
        public string Privacy { get; set; }
        public string Email { get; set; }
        public string Pricing { get; set; }
        public string Products { get; set; }
        public string Payment { get; set; }
        public string Deliveries { get; set; }
        public string Returntxt { get; set; }
        public string Nondelivery { get; set; }
        public long? Siteid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
