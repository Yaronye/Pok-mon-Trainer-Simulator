using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{

    abstract class Pokemon() : IEvolveable
    {
        public string Name { get; set; }
        public int Level { get; set; }
        public ElementType Type { get; set; }
        public List<Attack> Attacks { get; set; }

        public void Evolve(string newName, int levels)
        {
            int newLevel = LevelAdditionCheck(levels);
            NameCheck(newName); 

            Console.WriteLine("What's this? {0} is evolving...\n.\n.\n.\n!\n{0} evolved into {1}!", Name, newName);
            Console.WriteLine("Their level increased from {0} to {1}!", Level, Level + newLevel);

            Name = newName;
            Level = newLevel;
        }

        public void RandomAttack()
        {
            // Picks a random attack from the list of attacks and invokes its .Use-method.
            Random random = new Random();
            int randomAtk = random.Next(0, Attacks.Count);
        }

        public void Attack()
        {
            // Lets the user pick an attack from the list of attacks and invoke its .Use-method.
            bool isInt = true;
            int choice = 0;
            ShowAttacks();
            Console.WriteLine("Enter choice ");
            while (isInt)
            {
                try
                {
                    choice = Int32.Parse(Console.ReadLine()!);
                }
                catch (FormatException)
                {
                    Console.WriteLine($"Unable to parse entry to int + \n Try again.");
                    isInt = false;
                }
            }
            Console.WriteLine("You chose {0}", Attacks[choice - 1]);
        }

        bool NameCheck(string name)
        {
            if (name.Length < 2 || name.Length > 15)
            {
                throw new ArgumentException("Invalid name length");
            }
            else { return true; }
        }

        int LevelAdditionCheck(int increment)
        {
            if (Level + increment < 0)
            {
                throw new ArgumentException("Invalid level");
            }
            else if (Level + increment > 100)
            {
                return 100;
            }
            else
            {
                return increment;
            }
        }
        public void ShowAttacks()
        {
            int count = 1;
            foreach (Attack attack in Attacks)
            {
                Console.WriteLine(count + " " + attack);
                count++;
            }
        }

        public void RaiseLevel(int increment)
        {
            // That should increment the level of the given pokemon and print that the pokemon has leveled up.
            Console.WriteLine("Your {2} leveled up!\nlvl.{0} -> {1}\n", Level, Level + increment, Name);
            Level += increment;
        }

        public class FirePokemon : Pokemon, IEvolveable
        {
            public FirePokemon()
            {
                Type = ElementType.Fire;
            }
            public void Evolve()
            {
                Evolve("Quilava", 10);
            }
        }

        public class WaterPokemon : Pokemon, IEvolveable
        {
            public WaterPokemon()
            {
                Type = ElementType.Water;
            }
            public void Evolve()
            {
                Evolve("Croconaw", 10);
            }
        }

        public class ElectricPokemon : Pokemon, IEvolveable
        {
            public ElectricPokemon()
            {
                Type = ElementType.Electric;
            }
            public void Evolve()
            {
                Evolve("Raichu", 10);
            }
        }
    }
}
