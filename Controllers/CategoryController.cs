using Microsoft.AspNetCore.Mvc;
using supermasks.biz;
using supermasks.Core;
using System.Collections.Generic;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class CategoryController : Controller
    {
        private readonly IUnitOfWork _context;
        public CategoryController(IUnitOfWork context)
        {
            _context = context;
        }

        [Route("api/GetMainCategories")]
        public IEnumerable<cats> GetMainCategories()
        {
            return _context.Cats.GetBizCats("");
        }

        [Route("api/GetSubCategories")]
        public IEnumerable<cats> GetSubCategories(string url)
        {
            return _context.Cats.GetBizCats(url);
        }
    }
}