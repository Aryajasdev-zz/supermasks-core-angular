using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class RecentprodsDetails
    {
        public long Recentid { get; set; }
        public string Sessionid { get; set; }
        public long? Prodid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
