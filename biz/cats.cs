using System.Collections.Generic;

namespace supermasks.biz
{
    public class cats
    {              
        public int Code { get; set; }
        public string Name { get; set; }
        public string Longname { get; set; }
        public string Url { get; set; }
        public string Catimg { get; set; }  
        public IEnumerable<cats> Subcats { get; set; }        
    }
}
