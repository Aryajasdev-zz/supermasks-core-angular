using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ReorderRepository : Repository<ReorderDetails>, IReorderRepository
    {
        public ReorderRepository(fantasyfaceContext context) : base(context){ }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
