using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class Baskets
    {
        public long Basketid { get; set; }
        public string Bsession { get; set; }
        public long? Prodid { get; set; }
        public long? Sizeid { get; set; }
        public decimal? Price { get; set; }
        public long? Qty { get; set; }
        public string Orderid { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Lpage { get; set; }
        public long? Basketstatus { get; set; }
        public byte? Status { get; set; }
        public byte? Isvat { get; set; }
        public long? Custid { get; set; }
    }
}
