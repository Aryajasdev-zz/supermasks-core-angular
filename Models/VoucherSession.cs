using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class VoucherSession
    {
        public long Sid { get; set; }
        public string Sessionid { get; set; }
        public string Voucher { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
