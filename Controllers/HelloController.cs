using Microsoft.AspNetCore.Mvc;

namespace dotnet_core_heroku.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HelloController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get(string name)
        {
            return Ok(new { message = $"Hello, {name}" });
        }
    }
}
