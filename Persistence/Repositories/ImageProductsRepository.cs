using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ImageProductsRepository : Repository<ImageProds>, IImageProductsRepository
    {
        public ImageProductsRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
