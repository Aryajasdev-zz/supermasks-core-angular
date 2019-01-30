using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class CatsImages
    {
        public long Catimageid { get; set; }
        public long? Catcode { get; set; }
        public string Catimg { get; set; }
        public string Headimg { get; set; }
        public string Menuimg { get; set; }
        public long? Siteid { get; set; }
        public int? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
