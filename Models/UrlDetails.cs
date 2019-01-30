using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class UrlDetails
    {
        public long Urlid { get; set; }
        public string Url { get; set; }
        public long? Lvl { get; set; }
        public long? Catcode { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
