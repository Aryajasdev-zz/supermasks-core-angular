using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class OfferDetails
    {
        public long Offerid { get; set; }
        public DateTime? Sdate { get; set; }
        public DateTime? Edate { get; set; }
        public long? Discount { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Status { get; set; }
    }
}
