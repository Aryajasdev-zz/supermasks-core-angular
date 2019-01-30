using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class VoucherDetails
    {
        public long Gvid { get; set; }
        public string Vcode { get; set; }
        public decimal? Vamt { get; set; }
        public string Terminal { get; set; }
        public long? Transactionid { get; set; }
        public byte? Redemed { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
