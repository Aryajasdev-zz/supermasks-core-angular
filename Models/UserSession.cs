using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class UserSession
    {
        public long Sessionid { get; set; }
        public string Sessiond { get; set; }
        public long? Userid { get; set; }
        public byte? Iscompleted { get; set; }
        public DateTime? Logindate { get; set; }
        public DateTime? Logoutdate { get; set; }
    }
}
