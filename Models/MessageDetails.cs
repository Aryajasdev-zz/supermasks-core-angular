using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class MessageDetails
    {
        public long Msgid { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
