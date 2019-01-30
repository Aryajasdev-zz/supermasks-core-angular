using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class RelatedProds
    {
        public long Relid { get; set; }
        public long? Prodid { get; set; }
        public long? Rprodid { get; set; }
        public long? Userid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
