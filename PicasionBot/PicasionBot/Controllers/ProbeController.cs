using Microsoft.AspNetCore.Mvc;

namespace PicasionBot.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProbeController : ControllerBase
    {
        [HttpGet]
        [Route("ready")]
        public IActionResult IsReady()
        {
            return Ok();
        }

        [HttpGet]
        [Route("alive")]
        public IActionResult IsAlive()
        {
            return Ok();
        }
    }
}