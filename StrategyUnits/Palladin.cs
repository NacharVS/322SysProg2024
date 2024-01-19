using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {


        public Palladin(int health, string name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {
        }

        public void MagicDemage( Unit unit)
        {
            if(120 > Energy)
            {
                Console.WriteLine("No Mana");
            }
            else
            {
                unit.Health -= 40;
                Energy -= 120;
                Console.WriteLine($"Demage {40} hp to {unit.Name}");
            } 
        }
        public void Prayer()
        {
            if(Energy > 10)
            {
                while(Energy < 10)
                {
                    Health += 20;
                    Energy -= 10;
                }
            }
            else
            {
                Console.WriteLine("No Heal");
            }
        }
    }
}
