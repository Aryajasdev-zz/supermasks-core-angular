using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ApiDetails
    {
        public long Apiid { get; set; }
        public string Apikey { get; set; }
        public long? Userid { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
