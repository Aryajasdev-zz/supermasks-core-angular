using System;
using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface IErrorlogRepository : IRepository<ErrorLog>
    {
        void create_errorlog(Int32 moduleid, string msg, string appcode, string mfunction);
    }
}
