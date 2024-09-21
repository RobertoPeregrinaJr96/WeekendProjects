using Microsoft.AspNetCore.Mvc;

namespace YourNamespace.Controllers // Replace 'YourNamespace' with your actual namespace
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorldController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Hello World");
        }
    }
}
