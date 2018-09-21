using System;

namespace PicasionBot.Application.Dtos
{
    public class ActionWithTarget : BaseAction
    {
        public Guid Target { get; set; }
    }
}
