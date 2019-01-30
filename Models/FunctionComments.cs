using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class FunctionComments
    {
        public long Fcid { get; set; }
        public long? Userid { get; set; }
        public string Comment { get; set; }
        public long? Prodid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
