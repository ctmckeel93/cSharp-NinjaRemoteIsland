using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Sensei : Hero
    {
        public override void SayName()
        {
            Console.WriteLine($"You've earned the {this.Level} level!");
        }

        public Sensei(Ninja obj) : base(obj.Name, obj.AttackStat)
        {
            // Name = obj.Name;
            // AttackStat = obj.AttackStat;
            Strength = obj.Strength * 2;
            Dexterity = obj.Dexterity * 2;
            Speed = obj.Speed * 2;
            health = obj.health + 100;
            Inventory = obj.Inventory;
        }
    }
}