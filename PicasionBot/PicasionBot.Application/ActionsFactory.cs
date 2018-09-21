using System;
using PicasionBot.Application.Dtos.Actions;

namespace PicasionBot.Application
{
    public static class ActionsFactory
    {
        public static BaseAction Rest(Guid allyId)
        {
            return new RestAction(allyId);
        }
    }
}
