using System.Diagnostics;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using supermasks.Core;
using supermasks.Models;

namespace supermasks.Controllers
{
    public class HomeController : Controller
    {
        private readonly IUnitOfWork _context;
        private readonly IConfiguration _configuration;        
        public HomeController(IUnitOfWork context, IConfiguration configuration)
        {
            _context = context;
            _configuration = configuration;            
        }

        public IActionResult Index(string url)
        {
            try
            {                
                if (url == null)
                {
                    var cats = _context.Cats.GetBizCats("");
                    return View(cats);
                }
                else
                {                   
                    ViewBag.url = url;
                    var Url = _context.Urls.SingleOrDefault(x => x.Url == url);
                    return (Url.Lvl == 4) ? View("product") : View("products");                    
                }
            }
            catch {
                return View();
            }
        }

        public IActionResult Checkout()
        {
            return View();
        }

        public IActionResult orders()
        {
            return View();
        }

        public IActionResult account()
        {
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
