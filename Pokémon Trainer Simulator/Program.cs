
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
            List<Pokemon> TrainerPokemons = new List<Pokemon>();

            //Create attacks
            var flamethrower = new Attack("Flamethrower", ElementType.Fire, 12);
            var ember = new Attack("Ember", ElementType.Fire, 6);
            var watergun = new Attack("Watergun", ElementType.Water, 5);
            var surf = new Attack("Surf", ElementType.Water, 15);
            var thunderwave = new Attack("Thunderwave", ElementType.Electric, 3);
            var thunderbolt = new Attack("Thunderbolt", ElementType.Electric, 20);

            //Create pokemons
            var cyndaquil = new Pokemon.FirePokemon //create cyndaquil
            { 
                Name = "Cyndaquil",
                Level = 3,
                Attacks = new List<Attack> { ember, flamethrower }
            };

            var totodile = new Pokemon.WaterPokemon
                { 
                Name = "Totodile",
                Level = 5,
                Attacks = new List<Attack> { watergun, surf }
                };

            var pikachu = new Pokemon.ElectricPokemon
            {
                Name = "Pikachu",
                Level = 10,
                Attacks = new List<Attack> { thunderwave, thunderbolt }
            };

            //add pokemon to trainer list
            TrainerPokemons.Add(cyndaquil);
            TrainerPokemons.Add(totodile);
            TrainerPokemons.Add(pikachu);

            //thunderbolt.Use(9);

            totodile.RaiseLevel(2);
            pikachu.RaiseLevel(3);
            cyndaquil.RaiseLevel(1);

            cyndaquil.Evolve();
            totodile.Evolve();
            pikachu.Evolve();


        }
    }
}
