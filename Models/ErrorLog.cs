using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ErrorLog
    {
        public long Logid { get; set; }
        public string Logval { get; set; }
        public string Appcode { get; set; }
        public long? Moduleid { get; set; }
        public string Mfunction { get; set; }
        public long? Userid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
