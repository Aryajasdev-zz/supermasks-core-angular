using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class ConfirmDetails
    {
        public long Id { get; set; }
        public string Timestamp { get; set; }
        public string Result { get; set; }
        public string Orderid { get; set; }
        public string Message { get; set; }
        public string Authcode { get; set; }
        public string Md5hash { get; set; }
    }
}
