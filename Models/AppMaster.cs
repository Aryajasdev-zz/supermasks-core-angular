using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class AppMaster
    {
        public long Appid { get; set; }
        public string Name { get; set; }
        public string Appcode { get; set; }
        public byte? Status { get; set; }
    }
}
