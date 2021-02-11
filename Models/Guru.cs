using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Guru : Ninja
    {
        public override void SayName()
        {
            Console.WriteLine($"You've earned the {this.Level} level!");
        }

        public Guru(Sensei obj) : base(obj.Name, obj.AttackStat)
        {
            Name = obj.Name;
            AttackStat = obj.AttackStat;
            Strength = obj.Strength * 2;
            Dexterity = obj.Dexterity * 2;
            Speed = obj.Speed * 2;
            health = obj.health + 100;
            Inventory = obj.Inventory;
        }
    }
}