using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class CurrenciesRepository : Repository<CurrencyMaster>, ICurrenciesRepository
    {
        public CurrenciesRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
    
}