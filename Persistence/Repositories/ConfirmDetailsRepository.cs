using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ConfirmDetailsRepository : Repository<ConfirmDetails>, IConfirmDetailsRepository
    {
        public ConfirmDetailsRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
    
}