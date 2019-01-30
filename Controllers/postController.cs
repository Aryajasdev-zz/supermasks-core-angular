using Microsoft.AspNetCore.Mvc;
using supermasks.biz;

namespace supermasks.Controllers
{
    [Produces("application/json")]
    [Route("api/post")]
    public class postController : Controller
    {
        [HttpPost]
        public IActionResult postdata([FromBody] RootObject data)
        {
            return Ok();
        }
    }
}