
using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Harambe : Hero
    {
        
        public override void SayName()
        {
            Console.WriteLine($"Get ready for a boss fight! {Name} attacked");
        }

        public Harambe(string name, string stat) : base(name, stat)
        {
            Name = name;
            AttackStat = stat;
            Strength = 30;
            Dexterity = 10;
            Speed = 15;
            health = 500;
            Experience = 1000;
        }
    }
}