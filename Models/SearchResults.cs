using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SearchResults
    {
        public long Srid { get; set; }
        public long? Prodid { get; set; }
        public long? Userid { get; set; }
        public long? Srank { get; set; }
        public long? Sid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
