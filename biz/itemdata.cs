using System.Collections.Generic;

namespace supermasks.biz
{

    public class Item
    {
        public string id { get; set; }
        public string name { get; set; }
        public double price { get; set; }
        public int quantity { get; set; }
        public double total { get; set; }
        public string url { get; set; }
        public string img { get; set; }
        public string sizeid { get; set; }
        public string isstock { get; set; }
    }

    public class Itemdata
    {
        public int postageid { get; set; }
        public double subTotal { get; set; }
        public double totalCost { get; set; }
        public double discount { get; set; }
        public string discode { get; set; }
        public List<Item> items { get; set; }
    }

    public class Billdata
    {
        public string cardTitle { get; set; }
        public string cardName { get; set; }
        public string cardHno { get; set; }
        public string cardAddress { get; set; }
        public string cardCity { get; set; }
        public string cardCounty { get; set; }
        public string cardCountry { get; set; }
        public string cardPostcode { get; set; }
        public string email { get; set; }
        public string cfmail { get; set; }
        public string phone { get; set; }
    }

    public class Deldata
    {
        public string cardTitle { get; set; }
        public string cardName { get; set; }
        public string cardHno { get; set; }
        public string cardAddress { get; set; }
        public string cardCity { get; set; }
        public string cardCounty { get; set; }
        public string cardCountry { get; set; }
        public string cardPostcode { get; set; }
        public string email { get; set; }
        public string cfmail { get; set; }
        public string phone { get; set; }
    }

    public class RootObject
    {
        public Itemdata itemdata { get; set; }
        public Billdata billdata { get; set; }
        public Deldata deldata { get; set; }
        public string type { get; set; }
        public int siteid { get; set; }
    }    
}
