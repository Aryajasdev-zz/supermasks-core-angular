using System.Collections.Generic;
using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface IProductsRepository : IRepository<ProductMaster>
    {
        IEnumerable<ProductMaster> GetProducts(string url);
        ProductMaster GetProduct(string url);
        IEnumerable<ProductMaster> GetSorted(string sorttype, IEnumerable<ProductMaster> prods);
        void setDisableProduct(int prodid);
        void setEnableProduct(int prodid);
    }
}
