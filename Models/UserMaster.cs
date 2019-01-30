using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class UserMaster
    {
        public long Userid { get; set; }
        public string Username { get; set; }
        public string Userpass { get; set; }
        public DateTime? Lastonline { get; set; }
        public string Sessid { get; set; }
        public long? Roleid { get; set; }
        public long? Ecode { get; set; }
        public string Email { get; set; }
        public string Epass { get; set; }
        public byte? Status { get; set; }
        public DateTime Entrydate { get; set; }
        public byte? Pricesite { get; set; }
    }
}
