using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PageMaster
    {
        public long Pageid { get; set; }
        public string Pagename { get; set; }
        public string Headimg { get; set; }
        public string H1txt { get; set; }
        public string H2txt { get; set; }
        public string Seotop { get; set; }
        public string Seobot { get; set; }
        public string Metakey { get; set; }
        public string Metadesc { get; set; }
        public string Url { get; set; }
        public long? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
