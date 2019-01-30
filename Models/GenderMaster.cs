using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class GenderMaster
    {
        public long Genderid { get; set; }
        public string Gender { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
