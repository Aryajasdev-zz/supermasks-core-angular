using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class AgentMaster
    {
        public long Agentid { get; set; }
        public string Title { get; set; }
        public string Fname { get; set; }
        public string Lname { get; set; }
        public string Address { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public string Pcode { get; set; }
        public string Country { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string Vat { get; set; }
        public double? Share { get; set; }
        public string Password { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
    }
}
