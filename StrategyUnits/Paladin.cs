using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() :base(50, 5, 10, 5,20, "Паладин" ) 
        { 
        }
        public void SaintTouch(Unit unit) 
        { 
        if (Energy >= 9)
            {
                unit.GetDamage(RandomDamage() + unit.Defense);
                Energy -= 9;
            }
        else
            {
                Console.WriteLine($"{Name} don't have enough energy to cast this spell! ");
            }
        }
        
    }
}
