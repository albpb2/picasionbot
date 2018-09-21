namespace PicasionBot.Application.Dtos
{
    using Microsoft.AspNetCore.Mvc;
    using System;

    public class Weapon
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        [BindProperty(Name = "ap_cost")]
        public int CostInActionPoints { get; set; }
        [BindProperty(Name = "ap_damage")]
        public int DamagePerActionPoint { get; set; }
        public Var Durability { get; set; }
    }
}