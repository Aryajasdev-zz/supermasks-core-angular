using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class DiscountDetails
    {
        public long Discountid { get; set; }
        public long? Catid { get; set; }
        public long? Discount { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
