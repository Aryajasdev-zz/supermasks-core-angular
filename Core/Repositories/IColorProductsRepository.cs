using System;
using System.Collections.Generic;
using supermasks.Models;

namespace supermasks.Core.Repositories
{
    public interface IColorProductsRepository : IRepository<ColorProducts>
    {
        IEnumerable<ColorProducts> GetColorProducts();
    }
}