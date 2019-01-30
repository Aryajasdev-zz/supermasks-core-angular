using supermasks.Models;
namespace supermasks.Core.Repositories
{
    public interface ISeoDetailsRepository : IRepository<SeoDetails>
    {
        string GetHeader(int code);
        string GetFooter(int code);
    }
}
