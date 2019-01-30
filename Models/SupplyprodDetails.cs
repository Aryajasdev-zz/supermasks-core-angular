using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SupplyprodDetails
    {
        public long Spid { get; set; }
        public long? Prodid { get; set; }
        public long? Sid { get; set; }
        public string Minorder { get; set; }
        public string Pagenr { get; set; }
        public string Issue { get; set; }
        public long? Roid { get; set; }
        public string Prodcode { get; set; }
        public decimal? Rawcost { get; set; }
        public decimal? Cost { get; set; }
        public string Barcode { get; set; }
        public byte? Isdead { get; set; }
        public byte? Isbest { get; set; }
        public byte? Isbarcode { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Note { get; set; }
        public byte? Ischange { get; set; }

        public SupplyprodDetails Sp { get; set; }
        public SupplyprodDetails InverseSp { get; set; }
    }
}
