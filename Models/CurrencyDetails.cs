using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CurrencyDetails
    {
        public long Cdid { get; set; }
        public long? Cid { get; set; }
        public decimal? Rate { get; set; }
        public decimal? Rrate { get; set; }
        public long? Empid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
