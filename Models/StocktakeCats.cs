using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class StocktakeCats
    {
        public int Catid { get; set; }
        public int? Locked { get; set; }
        public int? Done { get; set; }
        public string Owner { get; set; }
        public DateTime? Lastaction { get; set; }
    }
}
