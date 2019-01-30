using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class LogDetails
    {
        public long Actionid { get; set; }
        public long? Id { get; set; }
        public long? Logtypeid { get; set; }
        public long? Siteid { get; set; }
        public long? Prodid { get; set; }
        public long? Userid { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
