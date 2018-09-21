using System;

namespace PicasionBot.Application.Dtos.Actions
{
    internal class RestAction : BaseAction
    {
        public RestAction(Guid allyId)
        {
            this.Action = "rest";
            this.Source = allyId;
        }
    }
}
