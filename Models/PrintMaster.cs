using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PrintMaster
    {
        public long Printid { get; set; }
        public string Printname { get; set; }
        public string Usp { get; set; }
        public byte? Status { get; set; }
        public string Rptcode { get; set; }
        public int? Porder { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
