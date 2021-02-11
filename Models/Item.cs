using cSharp_NinjaRemoteIsland.Interfaces;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Item : IAddable
    {
        public string Name;
        public string Boost {get;set;}
        public int Value {get;set;}


        public Item(string name, int val)
        {
            Name = name;
            Boost = "Health";
            Value = val;
        }

        
    }
}