using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class MessageRepository : Repository<MessageDetails>, IMessagesRepository
    {
        public MessageRepository(fantasyfaceContext context) : base(context)
        {
        }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
    
}