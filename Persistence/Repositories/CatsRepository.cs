using System.Collections.Generic;
using System.Linq;
using supermasks.biz;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class CatsRepository : Repository<CatsMaster>, ICatsRepository
    {
        public CatsRepository(fantasyfaceContext context) : base(context){ }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public IEnumerable<CatsMaster> GetMainCats()
        {
            return PssContext.CatsMaster.Where(x => x.Parentcode == 1000000).ToList();
        }

        public IEnumerable<CatsMaster> GetCats(int id)
        {
            return PssContext.CatsMaster.Where(x => x.Parentcode == id).ToList();
        }

        public IEnumerable<CatsMaster> GetCats(string url)
        {
            int code = PssContext.CatsMaster.SingleOrDefault(x => x.Url == url).Code;
            return PssContext.CatsMaster.Where(x => x.Parentcode == code).ToList();
        }

        public IEnumerable<cats> GetBizCats(string url)
        {
            var mcats = (url=="") ? GetMainCats() : GetCats(url);
            return (from x in mcats
                       join y in PssContext.CatsImages.Where(x => x.Siteid == 2).ToList()
                       on x.Code equals y.Catcode
                       select new cats
                       {
                           Code = x.Code,
                           Catimg = "https://www.supermasks.co.uk/images/mv/" + y.Catimg,
                           Name = x.Name,
                           Longname = x.Longname,
                           Url = x.Url,
                           Subcats = (x.Url == "" || x.Url == null) ? null : GetBizCats(x.Url)
                       });

        }
    }
}
