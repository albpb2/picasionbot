using System;
using System.Linq;
using Microsoft.AspNetCore.Mvc;
using PicasionBot.Application;
using PicasionBot.Application.Dtos;
using PicasionBot.Application.Dtos.Actions;

namespace PicasionBot.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class TurnController : ControllerBase
    {
        [HttpPost]
        public BaseAction Run(State state)
        {
            var firstAlly = state?.Allies?.FirstOrDefault();
            return ActionsFactory.Rest(firstAlly?.Id ?? Guid.Empty);
        }
    }
}