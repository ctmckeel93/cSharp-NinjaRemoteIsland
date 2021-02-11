
using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class GruntMonkey : Hero
    {
        
        public override void SayName()
        {
            Console.WriteLine($"(Grunt Monkey){Name} attacked");
        }

        public GruntMonkey(string name, string stat) : base(name, stat)
        {
            Name = name;
            AttackStat = stat;
            Strength = 3;
            Dexterity = 5;
            Speed = 15;
            health = 50;
            Experience = 10;
        }
    }
}