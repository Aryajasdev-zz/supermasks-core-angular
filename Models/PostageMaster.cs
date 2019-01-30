using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PostageMaster
    {
        public PostageMaster()
        {
            PresaleDetails = new HashSet<PresaleDetails>();
        }

        public long Postageid { get; set; }
        public string Mtype { get; set; }
        public string Method { get; set; }
        public string Mobile { get; set; }
        public decimal? Amount { get; set; }
        public decimal? Pamount { get; set; }
        public int? Telesale { get; set; }
        public int? Issignature { get; set; }
        public int? Isnd { get; set; }
        public int? Iseu { get; set; }
        public int? Isww { get; set; }
        public int? Issd { get; set; }
        public int? Porder { get; set; }
        public long? Siteid { get; set; }
        public byte? Isdiscount { get; set; }
        public byte? Isimp { get; set; }
        public string Message { get; set; }
        public int? Sdays { get; set; }
        public int? Edays { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }

        public ICollection<PresaleDetails> PresaleDetails { get; set; }
    }
}
