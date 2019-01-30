using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SalesinfoDetails
    {
        public long Sinfoid { get; set; }
        public string Email { get; set; }
        public string Tel { get; set; }
        public string Billing { get; set; }
        public string Delivery { get; set; }
        public long InfoId { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
