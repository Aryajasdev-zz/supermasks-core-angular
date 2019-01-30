using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using supermasks.biz;
using supermasks.Core;
using supermasks.Models;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class productsController : Controller
    {
        private readonly IUnitOfWork _context;
        public productsController(IUnitOfWork context)
        {
            _context = context;
        }

        [Route("api/GetProducts/{url}")]
        [HttpGet]
        public IEnumerable<ProductMaster> GetProducts(string url)
        {
            return _context.Products.GetProducts(url).OrderByDescending(x=> x.Isstock);
        }

        [Route("api/GetProduct/{url}")]
        [HttpGet]
        public ProductMaster GetProduct(string url)
        {
           return _context.Products.GetProduct(url);           
        }

        [Route("api/GetExtraImage/{id}")]
        [HttpGet]
        public IEnumerable<string> GetExtImages(int id)
        {
            return _context.ImageProducts.Find(x => x.Prodid == id).Select(x=> x.Imgname).ToList();
        }

        [Route("api/GetRelatedProducts/{id}")]
        [HttpGet]
        public IEnumerable<ProductMaster> GetRelated(int id)
        {            
            var prods = _context.Relatedprods.Find(x => x.Prodid == id).Select(x => x.Rprodid).ToArray();
            //var catprods = _context.CatProducts.Find(x => x.Prodid == id).Select(x => x.Prodid).ToArray();
            var products = _context.Products.Find(x => prods.Contains(x.Prodid) && x.Img.Length > 0 && x.Status == 1 && x.Webprice > 0);
            return products;
        }
    }
}