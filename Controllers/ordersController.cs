using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using supermasks.Core;
using supermasks.Models;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class ordersController : Controller
    {
        private readonly IUnitOfWork _context;
        public ordersController(IUnitOfWork context)
        {
            _context = context;
        }

        [Route("api/GetOrders/{custid}")]
        [HttpGet]
        public IEnumerable<SalesMaster> GetOrders(int custid)
        {
            return _context.Sales.Find(x => x.Custid == custid).ToList();
        }
    }
}