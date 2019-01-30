using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PricelistLogs
    {
        public long Logid { get; set; }
        public long? Spid { get; set; }
        public double? Lrcost { get; set; }
        public double? Lfcost { get; set; }
        public string Minorder { get; set; }
        public string Barcode { get; set; }
        public double? Nrcost { get; set; }
        public double? Nfcost { get; set; }
        public string Nminorder { get; set; }
        public string Nbarcode { get; set; }
        public string Prodcode { get; set; }
        public long? Userid { get; set; }
        public long? Updated { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
