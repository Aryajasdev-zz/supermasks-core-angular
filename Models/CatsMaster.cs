using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CatsMaster
    {
        public long Catid { get; set; }
        public int Code { get; set; }
        public int? Parentcode { get; set; }
        public string Name { get; set; }
        public string Longname { get; set; }
        public string Keywords { get; set; }
        public decimal? Pc { get; set; }
        public decimal? Onweb { get; set; }
        public int? Corder { get; set; }
        public string Url { get; set; }
        public byte? Ismain { get; set; }
        public byte? Status { get; set; }
        public byte? Issale { get; set; }
        public long? Maincatid { get; set; }
        public string Arsc { get; set; }   
        public int? Islens { get; set; }
    }
}
