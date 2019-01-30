using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PtierMaster
    {
        public long Ptid { get; set; }
        public string Pname { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
