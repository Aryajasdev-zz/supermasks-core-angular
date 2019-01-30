using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ProductLogs
    {
        public long Prodlogid { get; set; }
        public long? Prodid { get; set; }
        public long? Userid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
