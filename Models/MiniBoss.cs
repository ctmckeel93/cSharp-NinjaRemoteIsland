
using System;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class MiniBoss : Hero
    {
        
        public override void SayName()
        {
            Console.WriteLine($"(Mini Boss){Name} attacked");
        }

        public MiniBoss(string name, string stat) : base(name, stat)
        {
            Name = name;
            AttackStat = stat;
            Strength = 8;
            Dexterity = 5;
            Speed = 15;
            health = 200;
            Experience = 50;
        }
    }
}