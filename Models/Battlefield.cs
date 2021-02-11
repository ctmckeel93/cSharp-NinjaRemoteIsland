using System.Collections.Generic;

namespace cSharp_NinjaRemoteIsland.Models
{
    public class Battlefield
    {
        public bool isGameOver {get;set;}
        public List<Hero> Party;
        public List<Hero> Enemies;
        public List<List<Hero>> Field;

        public Battlefield()
        {
            isGameOver = false;
            Field = new List<List<Hero>>();
            Party = new List<Hero>();
            Enemies = new List<Hero>();
            Field.Add(Party);
            Field.Add(Enemies);

        }
            public void Finalize(List<Hero> party, List<Hero> enemies)
            {
                int rewards = 0;
                for (int i = 1; i < enemies.Count; i++)
                {
                    rewards += enemies[i].Experience;
                }
                foreach (Hero player in party)
                {
                    player.Experience += rewards;
                }

            }
    }
}