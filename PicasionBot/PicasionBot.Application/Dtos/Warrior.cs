using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace PicasionBot.Application.Dtos
{
    public class Warrior
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Class { get; set; }
        public Var Health { get; set; }
        [BindProperty(Name = "ap")]
        public Var ActionPoints { get; set; }
        public IReadOnlyCollection<Weapon> Weapons { get; set; }
        public IReadOnlyCollection<Item> Items { get; set; }
    }
}
