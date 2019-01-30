using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class CatImagesRepository : Repository<CatsImages>, ICatImagesRepository
    {
        public CatImagesRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
