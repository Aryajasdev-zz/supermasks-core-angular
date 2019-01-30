using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class LogtypeMaster
    {
        public long Logtypeid { get; set; }
        public string Logtype { get; set; }
        public byte? Rpt { get; set; }
        public string Tbl { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
