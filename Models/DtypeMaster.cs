using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class DtypeMaster
    {
        public DtypeMaster()
        {
            PromotionMaster = new HashSet<PromotionMaster>();
        }

        public long Dtypeid { get; set; }
        public string Dtype { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }

        public ICollection<PromotionMaster> PromotionMaster { get; set; }
    }
}
