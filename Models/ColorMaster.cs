using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ColorMaster
    {
        public long Colorid { get; set; }
        public string Color { get; set; }
        public string Class { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
