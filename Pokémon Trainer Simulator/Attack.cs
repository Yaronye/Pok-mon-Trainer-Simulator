using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokémon_Trainer_Simulator
{
    internal class Attack(string name, ElementType type, int basePower)
    {
        string Name = name;
        ElementType Type = type;
        int BasePower = basePower;

        public void Use(string name, int level)
        {
            Console.WriteLine(name + " hits with total power of " + BasePower + level + "!\n");
        }
    }
}
