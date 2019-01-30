using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PrintReports
    {
        public long Rptid { get; set; }
        public long? Prodid { get; set; }
        public string Prodname { get; set; }
        public string Prodsize { get; set; }
        public decimal? Price { get; set; }
        public decimal? Sprice { get; set; }
        public decimal? Crprice { get; set; }
        public decimal? Webprice { get; set; }
        public long? Empid { get; set; }
        public long? Suppid { get; set; }
        public string Supplier { get; set; }
        public string Prodcode { get; set; }
        public long? Tierid { get; set; }
        public string Reorder { get; set; }
        public string Altsupp { get; set; }
        public string Altprodcode { get; set; }
        public byte? Online { get; set; }
        public byte? Roid { get; set; }
        public decimal? Cost { get; set; }
        public string Page { get; set; }
        public string Unit { get; set; }
        public long? Catcode { get; set; }
        public DateTime? Entrydate { get; set; }
        public long? Cnt { get; set; }
        public byte? Isbest { get; set; }
    }
}
