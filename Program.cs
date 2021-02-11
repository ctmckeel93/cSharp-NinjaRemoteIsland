using System;
using System.Collections.Generic;
using cSharp_NinjaRemoteIsland.Models;

namespace cSharp_NinjaRemoteIsland
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleRed("********NINJA: REMOTE ISLAND********");

            // Hero player = PlayerSetup();
            
            // ConsoleRed($"You, {player.Name}, decided to take cruise around the Pacific!  Unfortunately, there was a incident involving a wrong turn and a huge wave.  You blacked out and woke up to find yourself on a remote mysterious island.\n\nNow you must get to the beach so you can send out a distress signal and get back home.  What dangers and mysteries lurk within the jungle island?  Will you make it to the beach safely?  Is this the island with all the dinosaurs?\n\nPress Enter to Start");

            // ConsoleKey key  = Console.ReadKey(true).Key;
            // while(key != ConsoleKey.Enter)
            // {
            //     key  = Console.ReadKey(true).Key;
            // }
            // Console.WriteLine("BEGIN YOUR ADVENTURE HERE!!!");

            //write a method that will create other team mates.

            // make a game(while) loop to run your game
            Battlefield game = new Battlefield();
            // while (game.isGameOver == false)
            // {
            //     foreach (List <List<Hero>> field in game.Field)
            //     {
            //         if (field.Part.health < 0)
            //     }
            // }
        Ninja nin = new Ninja("Nin-nin", "Strength");
        nin.ShowStats();
        Sensei sensei = new Sensei(nin);
        Guru guru = new Guru(sensei);
        

        sensei.ShowStats();
        guru.ShowStats();
        }


        static void ConsoleRed(string text)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(text);
            Console.ResetColor();
        }

        static Hero PlayerSetup()
        {
            Console.WriteLine("What is your name?");

            string name = Console.ReadLine();
            string choice = "0";

            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Please type the number of the Weapon you would ike to start with?\n1. Sword\n2. Knife\n3. None");
                choice = Console.ReadLine();
            }

            switch (choice)
            {
                case("1"):
                    Ninja swordMaster = new Ninja(name, "Strength");
                    Weapon sword = new Weapon("Sword", "Strength", 3);
                    swordMaster.Equip(sword);
                    return swordMaster;
                case("2"):
                    // Change Ninja to another class of hero.
                    Ninja assassin = new Ninja(name, "Dexterity");
                    Weapon knife = new Weapon("Knife", "Dexterity", 2);
                    assassin.Equip(knife);
                    return assassin;
                case("3"):
                    // Change Ninja to another class of hero.
                    Ninja medic = new Ninja(name, "Strength");
                    Item potion = new Item("Potion", 10);
                    for (int i = 1; i <= 3; i++)
                    {
                        medic.Inventory.Add(potion);
                    }
                    return medic;
            }

            choice = "0";
            while( choice != "1" && choice != "2" && choice != "3")
            {
                Console.WriteLine("Where would you like to go?\n1. Walk the Beach\n2. Explore the Forest\n3. Enter Sea Cave");
                choice = Console.ReadLine();
            }
            switch (choice)
            {
                case("1"):
                    Console.WriteLine("You head down the beach, there seems to be something up ahead....");
                    Console.WriteLine("You encounted two monkey scouts. Looks like they're preparing to attack. They seem weak, but be on your toes!");
                    // start battle with two grunts
                    return null;
                case("2"):
                    Console.WriteLine("The trees are inviting, a nice break from the overbearing sun. The way increases in difficulty the further you go as the foilage becomes more dense. Suddenly, you hear noises all around you...");
                    Console.WriteLine("You encounted to monkey scouts. Looks like they're preparing to attack. They seem weak, but be on your toes!");
                    // start battle with four gruntsi
                    return null;
                case("3"):
                    Console.WriteLine("You enter the cave and wake something.... At least it's not a wampa, but you're still in trouble.");
                    Console.WriteLine("You encounted to monkey scouts. Looks like they're preparing to attack. They seem weak, but be on your toes!");
                    // start battle with boss
                    return null;
            }


            return null;
        }
    }
}
