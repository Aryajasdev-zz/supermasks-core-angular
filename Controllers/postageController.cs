using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using supermasks.Core;
using supermasks.Models;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class postageController : Controller
    {
        private readonly IUnitOfWork _context;
        public postageController(IUnitOfWork context)
        {
            _context = context;
        }

        [Route("api/GetPostages")]
        public IEnumerable<PostageMaster> GetPostages()
        {
            return _context.Postages.Find(x => x.Siteid == 2 && x.Telesale == 0).OrderBy(x => x.Porder).ToList();
        }
    }
}