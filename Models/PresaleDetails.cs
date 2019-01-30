using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PresaleDetails
    {
        public long Presaleid { get; set; }
        public string Orderid { get; set; }
        public string Name { get; set; }
        public string Custadd { get; set; }
        public string Deladd { get; set; }
        public string Code { get; set; }
        public string Custemail { get; set; }
        public string Custphone { get; set; }
        public long? Siteid { get; set; }
        public string Discountcode { get; set; }
        public decimal? Discount { get; set; }
        public decimal? Donation { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Postage { get; set; }
        public long? Postageid { get; set; }
        public string Ptype { get; set; }
        public byte? Istele { get; set; }
        public DateTime? Entrydate { get; set; }
        public long? Deviceid { get; set; }
        public string Bsession { get; set; }
        public long? Custid { get; set; }
        public string Curcode { get; set; }
        public decimal? Vat { get; set; }

        public PostageMaster PostageNavigation { get; set; }
    }
}
