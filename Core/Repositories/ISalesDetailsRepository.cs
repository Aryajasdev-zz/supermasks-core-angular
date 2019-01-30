using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface ISalesDetailsRepository : IRepository<SalesDetails>
    {
        bool UpdateMergeProd(int prodid1, int prodid2);
    }
}
