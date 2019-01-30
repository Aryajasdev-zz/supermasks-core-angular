using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using supermasks.biz;
using supermasks.Core;
using supermasks.Models;

namespace supermasks.Controllers
{
    [Produces("application/json")]    
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _context;
        public CustomerController(IUnitOfWork context)
        {
            _context = context;
        }

        // GET: api/Customer/5
        [Route("api/GetCustomer/{id}")]
        [HttpGet]
        public IActionResult GetCustomer(long id)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = _context.Customers.SingleOrDefault(x => x.Custid == id);
            if (customer == null)
            {
                return NotFound();
            }            
            return Ok(customer);
        }

        [Route("api/LoginCustomer")]
        [HttpPost]
        public IActionResult LoginCustomer([FromBody] Users user)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            var customer = _context.Customers.SingleOrDefault(x => x.Email == user.username && x.Password == _context.Common.MD5Hash(user.password));
            if (customer == null)
            {
                return NotFound();
            }          
            return Ok(customer);
        }


        // POST: api/Customer
        [Route("api/AddCustomer")]
        [HttpPost]
        public async Task<IActionResult> PostCustomer([FromBody] CustomerMaster customerMaster)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }

            _context.Customers.AddAsync(customerMaster);
            await _context.CompleteAsync();
            return CreatedAtAction("GetCustomer", new { id = customerMaster.Custid }, customerMaster);
        }        
    }
}