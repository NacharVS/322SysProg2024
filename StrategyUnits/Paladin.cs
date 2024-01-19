using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin(int health, int mindamage, int maxdamage, int defense, int energy, string? name) : base(health, mindamage, maxdamage, defense, energy, name)
        {
        }

        public void SaintTouch(Unit unit) 
        { 
        if (Energy >= 9)
            {
                unit.GetDamage(CountDamage() + unit.Defense);
                Energy -= 9;
            }
        else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }
        public void Prayer()
        {
            if(Energy >= 10)
            {
                Energy -= 10;
                GetHeal(20);
            }
            else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }
    }
}
