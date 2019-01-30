using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class StocktakeDetails
    {
        public long Rptid { get; set; }
        public long? Empid { get; set; }
        public long? Catcode { get; set; }
        public long? Ncode { get; set; }
        public long? Qty { get; set; }
        public double? Val { get; set; }
        public long? Qtylast { get; set; }
        public double? Vallast { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
