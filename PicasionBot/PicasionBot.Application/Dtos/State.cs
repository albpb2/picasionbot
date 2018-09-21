using System.Collections.Generic;

namespace PicasionBot.Application.Dtos
{
    public class State
    {
        public Var Turns { get; set; }
        public IReadOnlyCollection<Warrior> Allies { get; set; }
        public IReadOnlyCollection<Warrior> Enemies { get; set; }
        public IReadOnlyCollection<Weapon> Weapons { get; set; }
        public IReadOnlyCollection<Item> Items { get; set; }
    }
}
