using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ImageProds
    {
        public long Imageid { get; set; }
        public long? Prodid { get; set; }
        public string Imgname { get; set; }
        public long? Userid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
