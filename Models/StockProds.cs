using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class StockProds
    {
        public long Stockid { get; set; }
        public long Prodid { get; set; }
        public long? Store { get; set; }
        public long? Trade { get; set; }
        public double? Val { get; set; }
        public long? Userid { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Locked { get; set; }
    }
}
