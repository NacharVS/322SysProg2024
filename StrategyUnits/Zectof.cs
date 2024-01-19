using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zectof : Palladin
    {
        public Zectof(int health, string name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {

        }
        public void ArmorOFFsith()
        {
            if(Health < MaxHealth * 0.30)
            {
                Defence = Defence + Defence;
            }
            else
            {
                Console.WriteLine("No arm");
            }
        }
    }
}
