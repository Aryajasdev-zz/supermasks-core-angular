using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class PostagesRepository : Repository<PostageMaster>, IPostagesRepository
    {
        public PostagesRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
