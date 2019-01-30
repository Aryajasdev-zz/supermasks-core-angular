using System;
using System.Collections.Generic;

namespace supermasks.Models
{
    public partial class SiteMaster
    {
        public long Siteid { get; set; }
        public string Sitename { get; set; }
        public string Sitedescription { get; set; }
        public string Sitecode { get; set; }
        public string Servername { get; set; }
        public string Dbname { get; set; }
        public string Add1 { get; set; }
        public string Add2 { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public byte? Isonline { get; set; }
        public byte? Priceid { get; set; }
        public string Website { get; set; }
        public string Imgfolder { get; set; }
        public string Realcode { get; set; }
        public string Realmoto { get; set; }
        public string Paypalemail { get; set; }
        public string Maintitle { get; set; }
        public string Metadesc { get; set; }
        public string Metakeys { get; set; }
        public long? Order { get; set; }
        public byte? Status { get; set; }
        public DateTime? Entrydate { get; set; }
        public string Ssite { get; set; }
    }
}
