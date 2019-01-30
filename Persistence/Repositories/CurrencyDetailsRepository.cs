using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class CurruncyDetailsRepository : Repository<CurrencyDetails>, ICurrencyDetailsRepository
    {
        public CurruncyDetailsRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
    
}