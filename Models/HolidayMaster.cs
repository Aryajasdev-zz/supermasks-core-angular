using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class HolidayMaster
    {
        public long Holidayid { get; set; }
        public DateTime Hdate { get; set; }
        public int Status { get; set; }
    }
}
