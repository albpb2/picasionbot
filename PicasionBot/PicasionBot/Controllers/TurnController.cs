
using Microsoft.AspNetCore.Mvc;

namespace PicasionBot.Controllers
{
    using Application.Dtos;

    [Route("[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        [HttpPost]
        public BaseAction Run(State state)
        {
            return new BaseAction();
        }
    }
}