using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ReorderDetails
    {
        public long Roid { get; set; }
        public string Name { get; set; }
        public byte? Rorder { get; set; }
        public byte? Sorder { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Status { get; set; }
    }
}
