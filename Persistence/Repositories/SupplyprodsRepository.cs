using System;
using System.Linq;
using supermasks.Core.Repositories;
using supermasks.Models;

namespace supermasks.Persistence.Repositories
{
    public class SupplyprodsRepository : Repository<SupplyprodDetails>, ISupplyprodsRepository
    {
        public SupplyprodsRepository(fantasyfaceContext context) : base(context) { }

        public fantasyfaceContext PssContext
        {
            get { return Context as fantasyfaceContext; }
        }

        public decimal getAverageCost(int prodid)
        {
            var supplyprods = (from sp in PssContext.SupplyprodDetails
                where sp.Prodid == prodid && sp.Isbest == 3
                select new
                {
                    cost = (sp.Rawcost == null || sp.Rawcost <= 0) ? 0.10m : sp.Rawcost
                }).SingleOrDefault();

            if (supplyprods != null)
            {
                return (decimal) supplyprods.cost;
            }
            return 0.10m;
        }

        public int GetSecondSPID(int _prodid)
        {
            var reorder = PssContext.ReorderDetails.Where(x => x.Status == 1).ToList();
            var supplyprods = (from sp in PssContext.SupplyprodDetails.Where(x => x.Prodid == _prodid && x.Isdead == 1 && x.Isbest != 3)
                join ro in PssContext.ReorderDetails on sp.Roid equals ro.Roid
                select new
                {
                    spid = sp.Spid,
                    cost = (sp.Cost == null) ? (decimal)100.00 : sp.Cost,
                    rorder = ro.Rorder,
                    sid = sp.Sid
                });
            return (int)supplyprods.OrderBy(r => r.rorder).OrderBy(r => r.cost).OrderBy(r => r.sid).SingleOrDefault().sid;
        }

        public Int32 GetSPID(int _prodid)
        {
            var reorder = PssContext.ReorderDetails.Where(x=> x.Status==1).ToList();
            var supplyprods = (from sp in PssContext.SupplyprodDetails.Where(x => x.Prodid == _prodid && x.Isdead == 1)
                join ro in PssContext.ReorderDetails on sp.Roid equals ro.Roid
                select new
                {
                    spid = sp.Spid,
                    cost = (sp.Cost == null) ? (decimal) 100.00 : sp.Cost,
                    rorder = ro.Rorder,
                    sid = sp.Sid
                });
            return (int) supplyprods.OrderBy(r => r.rorder).OrderBy(r => r.cost).OrderBy(r => r.sid).SingleOrDefault().sid;
        }

        public void resetBestSuppliers(int _prodid)
        {
            var supplyprods = PssContext.SupplyprodDetails.Where(x => x.Prodid == _prodid);
            foreach (var sp in supplyprods)
            {
                sp.Isbest = 0;
            }

            PssContext.SaveChanges();
        }

        
        public void setBestSupplier(int prodid)
        {
            resetBestSuppliers(prodid);
            var supplyprods = PssContext.SupplyprodDetails.Find(GetSPID(prodid));
            supplyprods.Isbest = 3;
            PssContext.SaveChanges();
        }

        public void setSecondSupplier(int prodid)
        {
            var supplyprods = PssContext.SupplyprodDetails.Find(GetSecondSPID(prodid));
            supplyprods.Isbest = 2;
            PssContext.SaveChanges();
        }
    }
}
