using supermasks.biz;
using supermasks.Models;
using System.Collections.Generic;

namespace supermasks.Core.Repositories
{
    public interface ICatsRepository : IRepository<CatsMaster>
    {
        IEnumerable<CatsMaster> GetMainCats();
        IEnumerable<CatsMaster> GetCats(int id);
        IEnumerable<CatsMaster> GetCats(string url);
        IEnumerable<cats> GetBizCats(string url);
    }
}
