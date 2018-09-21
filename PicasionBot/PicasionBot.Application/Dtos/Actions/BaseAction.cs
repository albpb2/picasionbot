using System;

namespace PicasionBot.Application.Dtos.Actions
{
    public abstract class BaseAction
    {
        public string Action { get; set; }
        public Guid Source { get; set; }
    }
}