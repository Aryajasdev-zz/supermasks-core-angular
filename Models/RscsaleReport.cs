using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class RscsaleReport
    {
        public long Rptid { get; set; }
        public long? Prodid { get; set; }
        public long? Store { get; set; }
        public long? Trade { get; set; }
        public long? Empid { get; set; }
        public DateTime? Entrydatetime { get; set; }
    }
}
