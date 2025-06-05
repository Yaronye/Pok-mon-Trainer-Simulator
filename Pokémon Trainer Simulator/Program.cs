
//https://github.com/Lexicon-LTU-2025/exercise-3-pokemon-simulator 
using System;
using System.Linq;
using System.Numerics;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            //attacks
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var watergun = new Attack("Watergun", ElementType.Water, 12);
            var surf = new Attack("Surf", ElementType.Water, 12);
            var thunderwave = new Attack("Thunderwave", ElementType.Electric, 12);
            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 12);
        //pokemon
            var cyndaquil = new Pokemon.FirePokemon //create cyndaquil
            { 
                Name = "Cyndaquil",
                Level = 3,
                Attacks = new List<Attack> { ember, flamethrower }
            };
            cyndaquil.Evolve("Quilava", 10);
        }
    }


}
