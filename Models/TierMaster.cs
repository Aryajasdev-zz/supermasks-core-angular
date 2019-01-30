using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class TierMaster
    {
        public long Tierid { get; set; }
        public string Tier { get; set; }
        public byte? Status { get; set; }
    }
}
