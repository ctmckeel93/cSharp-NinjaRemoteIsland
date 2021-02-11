using System;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Ninja : Hero
    {      
        public int TotalXP{get; set;}
        public override void SayName()
        {
            Console.WriteLine($"Hello My name is {Name}, and I'm a ninja.");
        }

        public Ninja(string name, string stat) : base(name, stat)
        {
            
        }

        public void UseItem(Ninja target, Item item)
        {
            target.Equip(item);
            Inventory.Remove(item);
        }
    }
}