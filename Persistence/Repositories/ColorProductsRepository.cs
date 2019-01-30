using System.Collections.Generic;
using System.Linq;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ColorProductsRepository : Repository<ColorProducts>, IColorProductsRepository
    {
        public ColorProductsRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public IEnumerable<ColorProducts> GetColorProducts()
        {
            return PssContext.ColorProducts.ToList();
        }
    }
    
}