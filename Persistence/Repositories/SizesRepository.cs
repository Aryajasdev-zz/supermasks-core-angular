using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class SizesRepository : Repository<SizeMaster>, ISizesRepository
    {
        public SizesRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
