using System;
using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface ISupplyprodsRepository : IRepository<SupplyprodDetails>
    {
        Int32 GetSPID(int prodid);
        Int32 GetSecondSPID(int prodid);
        void resetBestSuppliers(int prodid);
        void setBestSupplier(int prodid);
        void setSecondSupplier(int prodid);
        decimal getAverageCost(int prodid);
    }
    

}
