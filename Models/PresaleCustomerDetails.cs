using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PresaleCustomerDetails
    {
        public long Custaddid { get; set; }
        public string Orderid { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string City { get; set; }
        public string Pcode { get; set; }
        public byte? Status { get; set; }
    }
}
