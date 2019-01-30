using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class TermsMaster
    {
        public long Termid { get; set; }
        public long? Siteid { get; set; }
        public string Termstop { get; set; }
        public string Termsbot { get; set; }
        public string Returnpol { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
