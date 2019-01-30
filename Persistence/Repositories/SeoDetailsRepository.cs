using System.Linq;
using supermasks.Core;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class SeoDetailsRepository : Repository<SeoDetails>, ISeoDetailsRepository
    {
        public SeoDetailsRepository(fantasyfaceContext context) : base(context) { }

        public string GetHeader(int code)
        {
            var seo = PssContext.SeoDetails.SingleOrDefault(x => x.Catcode == code && x.Siteid == Global.Siteid);
            if(seo != null)
                return seo.Description.DefaultIfEmpty().ToString();
            return string.Empty;
        }

        public string GetFooter(int code)
        {
            var seo = PssContext.SeoDetails.SingleOrDefault(x => x.Catcode == code && x.Siteid == Global.Siteid);
            if (seo != null)
                return seo.Description2.DefaultIfEmpty().ToString();
            return string.Empty;
        }
        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }
    }
}
