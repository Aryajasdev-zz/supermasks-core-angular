using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SalesMaster
    {
        public long Infoid { get; set; }
        public string Info { get; set; }
        public string Pcode { get; set; }
        public string Orderid { get; set; }
        public long? Qty { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Postage { get; set; }
        public long? Siteid { get; set; }
        public long? Postageid { get; set; }
        public decimal? Donation { get; set; }
        public decimal? Discount { get; set; }
        public string Discountcode { get; set; }
        public string Paytype { get; set; }
        public string Paypalid { get; set; }
        public long? Userid { get; set; }
        public byte? Istele { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Sitecode { get; set; }
        public string Deltype { get; set; }
        public long? Deviceid { get; set; }
        public byte? Isprint { get; set; }
        public byte? Isremoved { get; set; }
        public long? Custid { get; set; }
        public string Curcode { get; set; }
        public decimal? Vat { get; set; }
        public byte? Status { get; set; }
    }
}
