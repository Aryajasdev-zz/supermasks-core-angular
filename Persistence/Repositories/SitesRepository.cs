using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class SitesRepository : Repository<SiteMaster>, ISitesRepository
    {
        public SitesRepository(fantasyfaceContext context) : base(context){}
        
        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
