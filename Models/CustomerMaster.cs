using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CustomerMaster
    {
        public long Custid { get; set; }
        public string Cname { get; set; }
        public string Title { get; set; }
        public string Cfname { get; set; }
        public string Clname { get; set; }
        public string Hno { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Pcode { get; set; }
        public string County { get; set; }
        public string Country { get; set; }
        public byte? Isdel { get; set; }
        public string Dhno { get; set; }
        public string Dstreet { get; set; }
        public string Dtown { get; set; }
        public string Dpcode { get; set; }
        public string Dcounty { get; set; }
        public string Dcountry { get; set; }
        public string Phone { get; set; }
        public string Fax { get; set; }
        public string Email { get; set; }
        public string Vat { get; set; }
        public long? Agentid { get; set; }
        public double? Discount { get; set; }
        public string Password { get; set; }
        public string Agent { get; set; }
        public byte? Isvat { get; set; }
        public string Customerno { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
