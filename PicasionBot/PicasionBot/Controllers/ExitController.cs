using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;

namespace PicasionBot.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ExitController : ControllerBase
    {
        private readonly IApplicationLifetime appLifetime;

        public ExitController(IApplicationLifetime appLifetime)
        {
            this.appLifetime = appLifetime;
        }

        [HttpPost]
        public IActionResult Exit()
        {
            appLifetime.StopApplication();
            return Ok();
        }
    }
}