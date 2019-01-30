using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SizeMaster
    {
        public long Specid { get; set; }
        public long Code { get; set; }
        public string Name { get; set; }
        public string Longname { get; set; }
        public string Sname { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
