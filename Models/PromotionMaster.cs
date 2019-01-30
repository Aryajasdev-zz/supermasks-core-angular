using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PromotionMaster
    {
        public long Dcid { get; set; }
        public string Code { get; set; }
        public double? Discount { get; set; }
        public long? Dtypeid { get; set; }
        public long? Siteid { get; set; }
        public DateTime? Startdate { get; set; }
        public DateTime? Enddate { get; set; }
        public double? Amount { get; set; }
        public string Img { get; set; }
        public string Name { get; set; }
        public long? Postageid { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }

        public DtypeMaster Dtype { get; set; }
    }
}
