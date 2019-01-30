using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CurrencyMaster
    {
        public long Cid { get; set; }
        public string Cname { get; set; }
        public string Ccode { get; set; }
        public string Ctcode { get; set; }
        public long? Corder { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
