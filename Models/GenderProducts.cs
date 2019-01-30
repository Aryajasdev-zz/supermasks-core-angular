using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class GenderProducts
    {
        public long Genindexid { get; set; }
        public long? Genderid { get; set; }
        public long? Prodid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
