using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class DmessageMaster
    {
        public long Msgid { get; set; }
        public string Msg { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public byte? Status { get; set; }
    }
}
