using System;

namespace PicasionBot.Application.Dtos.Actions
{
    public abstract class ActionWithTarget : BaseAction
    {
        public Guid Target { get; set; }
    }
}
