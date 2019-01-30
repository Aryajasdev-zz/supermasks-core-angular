using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class DiscountCodes
    {
        public long Dcid { get; set; }
        public string Dccode { get; set; }
        public float? Discount { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
