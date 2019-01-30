using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class RoleModule
    {
        public long Rmid { get; set; }
        public long? Roleid { get; set; }
        public long? Moduleid { get; set; }
        public byte? Roletype { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
