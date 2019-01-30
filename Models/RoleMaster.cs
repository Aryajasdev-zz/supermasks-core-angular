using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class RoleMaster
    {
        public long Roleid { get; set; }
        public string Role { get; set; }
        public string Note { get; set; }
        public int? Issuper { get; set; }
        public int? Isshop { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
