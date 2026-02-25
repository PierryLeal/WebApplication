using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HelloWorld : ControllerBase
    {

        [HttpGet()]
        public string Get()
        {
            return "Hello World";
        }
    }
}
