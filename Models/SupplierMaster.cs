using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SupplierMaster
    {
        public long Sid { get; set; }
        public string Name { get; set; }
        public decimal? Multiplier { get; set; }
        public string Address { get; set; }
        public string Contact { get; set; }
        public string Phone { get; set; }
        public string Site { get; set; }
        public string Userid { get; set; }
        public string Pass { get; set; }
        public string Note { get; set; }
        public string Scontact { get; set; }
        public string Sphone { get; set; }
        public string Sfax { get; set; }
        public decimal? Cpaid { get; set; }
        public string Mdetails { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Oldname { get; set; }
    }
}
