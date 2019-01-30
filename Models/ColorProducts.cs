using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ColorProducts
    {
        public long Colorindexid { get; set; }
        public long? Colorid { get; set; }
        public long? Prodid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
