using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class VerificationDetails
    {
        public long Verid { get; set; }
        public long? Custid { get; set; }
        public string Chk { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Status { get; set; }
    }
}
