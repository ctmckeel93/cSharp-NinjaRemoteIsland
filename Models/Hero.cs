using System;
using System.Collections.Generic;
using cSharp_NinjaRemoteIsland.Interfaces;

namespace cSharp_NinjaRemoteIsland.Models
{
    public abstract class Hero
    {
        public string Name{get;protected set;}
        public string AttackStat {get;set;}
        public int Dexterity{get;protected set;}
        public int Strength{get;protected set;}
        public int Speed{get;protected set;}
        public string Level{get;protected set;}
        public int health{get;protected set;}
        public int Experience {get; set;}
        public List<IAddable> Inventory {get; protected set;}

        public Hero(string name, string stat)
        {
            Name = name;
            AttackStat = stat;
            Dexterity = 5;
            Strength = 5;
            Speed = 5;
            health = 100;
            Experience = 0;
            Inventory = new List<IAddable>();
        }

        public abstract void SayName();

        public virtual void Equip(IAddable item)
        {
            Inventory.Add(item);
            switch(item.Boost)
            {
                case "Strength":
                        Strength += item.Value;
                        Speed -= item.Value;
                        break;
                case "Dexterity":
                    Dexterity += item.Value;
                    Speed += item.Value/2;
                    Strength -= item.Value;
                    break;
                default:
                    health += item.Value;
                    break;
            }
        }

        public void Attack(Hero target)
        {
            int damage;
            switch(AttackStat)
            {
                case "Dexterity":
                    damage = Dexterity * 5;
                    break;
                default:
                    damage = Strength * 5;
                    break;
            }
            double DODGE = 0.01;
            Random rand = new Random(); 
            if (rand.NextDouble() < (DODGE*target.Speed))
            {
                damage = 0;
            }
            target.health -= damage;
        }

        public virtual void ShowStats()
        {
            Console.WriteLine($"Name: {Name}\nDexterity: {Dexterity}\nStrength: {Strength}\nSpeed: {Speed}\nHealth: {health}");
        }



    }
}