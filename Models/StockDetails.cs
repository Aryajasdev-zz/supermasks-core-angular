using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class StockDetails
    {
        public long Stockid { get; set; }
        public long? Prodid { get; set; }
        public long? Qty { get; set; }
        public long? Userid { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Status { get; set; }
    }
}
