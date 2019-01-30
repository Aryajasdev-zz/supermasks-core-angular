using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ModuleMaster
    {
        public long Moduleid { get; set; }
        public string Mname { get; set; }
        public string Frmname { get; set; }
        public string Menu { get; set; }
        public long? Morder { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
