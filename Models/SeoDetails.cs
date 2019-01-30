using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SeoDetails
    {
        public long Seoid { get; set; }
        public decimal Catcode { get; set; }
        public long? Siteid { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string Keywords { get; set; }
        public string Title { get; set; }
        public string Header { get; set; }
        public string Header2 { get; set; }
        public string Metadesc { get; set; }
        public string Metakeys { get; set; }
        public string Breadcrumb { get; set; }
        public byte? Islive { get; set; }
    }
}
