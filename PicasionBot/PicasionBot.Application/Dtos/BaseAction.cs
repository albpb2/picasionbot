using System;

namespace PicasionBot.Application.Dtos
{
    public class BaseAction
    {
        public string Action { get; set; }
        public Guid Source { get; set; }
    }
}