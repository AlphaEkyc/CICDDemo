using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CICDdemo.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TestController : ControllerBase
    {

        [HttpGet("hello")]
        public IActionResult Hello()
        {
            return Ok(new
            {
                message = "Hello from Ubuntu server",
                app = "CICDDemoApi"
            });
        }

        [HttpGet("GetTime")]
        public IActionResult GetTime()
        {
            return Ok(new
            {
                servertime = DateTime.Now,
                utctime = DateTime.UtcNow,
            });
        }

        [HttpGet("Health")]

        public IActionResult Health()
        {
            return Ok(new
            {
                Health = "AppLication Running SuccessFully",
                machine = Environment.MachineName,
            });
        }
    }
}
