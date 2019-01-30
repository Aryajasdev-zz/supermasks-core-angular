using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ProductMaster
    {
        public long Prodid { get; set; }
        public string Prodcode { get; set; }
        public string Name { get; set; }
        public decimal? Price { get; set; }
        public decimal? Webprice { get; set; }
        public decimal? Sprice { get; set; }
        public decimal? Crprice { get; set; }
        public string Img { get; set; }
        public string Descr { get; set; }
        public string Keywords { get; set; }
        public string Notes { get; set; }
        public long? Volume { get; set; }
        public long? Minqty { get; set; }
        public long? Maxqty { get; set; }
        public long? Cqty { get; set; }
        public string Url { get; set; }
        public string Ptitle { get; set; }
        public string Mdesc { get; set; }
        public string Mkeys { get; set; }
        public long? Catcode { get; set; }
        public byte? Isreduced { get; set; }
        public byte? Isonline { get; set; }
        public byte? Isstock { get; set; }
        public byte? Isxl { get; set; }
        public long? Isshop { get; set; }
        public long? Mprodid { get; set; }
        public long? Sizeid { get; set; }
        public string Esize { get; set; }
        public byte? Ptid { get; set; }
        public long? Tierid { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }
        public byte? Zerovat { get; set; }
        public string Specification { get; set; }
        public string Delivery { get; set; }
        public string Pssdes { get; set; }
        public string Pndes { get; set; }
        public string Mdes { get; set; }
        public string Wdes { get; set; }
        public string Fbdes { get; set; }
        public byte? Isballoon { get; set; }
        public byte? Ischange { get; set; }
        public byte? Iscap { get; set; }
        public decimal? Oprice { get; set; }
        public decimal? Rrprice { get; set; }
        public decimal? Rwprice { get; set; }
        public byte? Soffer { get; set; }
        public byte? Wsale { get; set; }
        public byte? Btype { get; set; }
        public long? Colorid { get; set; }
    }
}
