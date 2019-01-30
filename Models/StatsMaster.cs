using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class StatsMaster
    {
        public long Statid { get; set; }
        public string Statname { get; set; }
        public string Usp { get; set; }
        public byte? Rtype { get; set; }
        public long? Rorder { get; set; }
        public string Rfrom { get; set; }
        public byte? Status { get; set; }
    }
}
