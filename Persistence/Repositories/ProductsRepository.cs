using System;
using System.Collections.Generic;
using System.Linq;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ProductsRepository : Repository<ProductMaster>, IProductsRepository
    {
        public ProductsRepository(fantasyfaceContext context) : base(context) { }
        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public ProductMaster GetProduct(string url)
        {
            return PssContext.ProductMaster.SingleOrDefault(x => x.Url == url);
        }

        public IEnumerable<ProductMaster> GetProducts(string url)
        {
            var Url = PssContext.UrlDetails.SingleOrDefault(x => x.Url == url);
            int ncode = (int)((Url.Lvl == 2) ? Url.Catcode + 1000 : Url.Catcode + 1);
            var prods = PssContext.CatsProducts.Where(x => x.Catcode >= Url.Catcode && x.Catcode < ncode).Select(x => x.Prodid).ToArray();
            return PssContext.ProductMaster.Where(x => prods.Contains(x.Prodid) && x.Status == 1).ToList();
        }

        public IEnumerable<ProductMaster> GetSorted(string sorttype, IEnumerable<ProductMaster> prods)
        {
            try
            {
                switch (sorttype)
                {
                    case "namea":
                        prods = prods.OrderBy(s => s.Name).OrderByDescending(s => s.Isstock);
                        break;
                    case "pricea":
                        prods = prods.OrderBy(s => s.Price).OrderByDescending(s => s.Isstock);
                        break;
                    case "priced":
                        prods = prods.OrderByDescending(s => s.Price).OrderByDescending(s => s.Isstock);
                        break;
                    default:
                        prods = prods.OrderByDescending(s => s.Isstock);
                        break;
                }
                return prods;
            }
            catch
            {
                return null;
            }
        }

        public void setDisableProduct(int prodid)
        {
            var product = PssContext.ProductMaster.Find(prodid);
            product.Status = 0;
            PssContext.SaveChanges();
        }

        public void setEnableProduct(int prodid)
        {
            var product = PssContext.ProductMaster.Find(prodid);
            product.Status = 1;
            PssContext.SaveChanges();
        }
    }
}
