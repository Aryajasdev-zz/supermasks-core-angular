using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CatsProducts
    {
        public long Catindexid { get; set; }
        public long? Catcode { get; set; }
        public long? Prodid { get; set; }
        public long? Ismain { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
