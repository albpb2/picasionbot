namespace PicasionBot.Application.Dtos.Actions
{
    public abstract class ActionWithExtra : ActionWithTarget
    {
        public string Extra { get; set; }
    }
}