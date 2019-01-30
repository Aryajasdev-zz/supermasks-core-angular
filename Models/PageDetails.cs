using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class PageDetails
    {
        public long Pagecatid { get; set; }
        public long? Pageid { get; set; }
        public long? Catcode { get; set; }
        public string Name { get; set; }
        public long? Status { get; set; }
    }
}
