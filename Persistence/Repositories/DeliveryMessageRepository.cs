using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class DeliveryMessageRepository : Repository<DmessageMaster>,IDeliveryMessageRepository 
    {
        public DeliveryMessageRepository(fantasyfaceContext context) : base(context){ }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}