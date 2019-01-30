using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class RelatedprodsRepository : Repository<RelatedProds>, IRelatedprodsRepository
    {
        public RelatedprodsRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
