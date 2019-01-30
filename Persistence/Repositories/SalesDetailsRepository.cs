using System;
using System.Linq;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class SalesDetailsRepository : Repository<SalesDetails>, ISalesDetailsRepository
    {
        public SalesDetailsRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public bool UpdateMergeProd(int prodid1, int prodid2)
        {
            var sales = PssContext.SalesDetails.Where(x => x.Prodid == prodid1);
            if (sales != null)
            {
                foreach (var s in sales)
                {
                    s.Prodid = prodid2;
                }
                PssContext.SaveChanges();
                return true;
            }

            return false;
        }
    }
}
