using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class TypeMaster
    {
        public long Itid { get; set; }
        public string Itcode { get; set; }
        public string Ittype { get; set; }
        public byte? Flag { get; set; }
        public byte? Status { get; set; }
    }
}
