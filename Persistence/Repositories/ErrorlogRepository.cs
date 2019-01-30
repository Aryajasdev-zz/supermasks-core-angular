using System;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class ErrorlogRepository : Repository<ErrorLog>, IErrorlogRepository
    {
        public ErrorlogRepository(fantasyfaceContext context) : base(context){ }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public void create_errorlog(int moduleid, string msg, string appcode, string mfunction)
        {
            PssContext.ErrorLog.Add(new ErrorLog
            {
                Userid = 1,
                Moduleid = moduleid,
                Appcode = appcode,
                Entrydate = DateTime.Now,
                Mfunction = mfunction,
                Logval = msg
            });
            PssContext.SaveChanges();
        }
    }
}

