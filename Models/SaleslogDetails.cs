using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SaleslogDetails
    {
        public long Slogind { get; set; }
        public string Info { get; set; }
        public long? Infoid { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
