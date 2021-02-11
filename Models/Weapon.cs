
using cSharp_NinjaRemoteIsland.Interfaces;


namespace cSharp_NinjaRemoteIsland.Models
{
    public class Weapon : IAddable
    {
        public string Name;
        public string Boost {get;set;}
        public int Value {get;set;}

        public Weapon(string name, string boost, int val)
        {
            Name = name;
            Boost = boost;
            Value = val;
        }
    }
}