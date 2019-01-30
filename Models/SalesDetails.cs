using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SalesDetails
    {
        public int Saleid { get; set; }
        public long? Siteid { get; set; }
        public long? Prodid { get; set; }
        public long? Sizeid { get; set; }
        public int? Qty { get; set; }
        public decimal? Price { get; set; }
        public long? InfoId { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Sitecode { get; set; }
        public byte? Isvat { get; set; }
    }
}
