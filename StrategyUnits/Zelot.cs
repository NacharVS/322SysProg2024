using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zelot : Paladin
    {
        public Zelot(int health, int mindamage, int maxdamage, string? name, int defence, int energy) : base(health, mindamage, maxdamage, name, defence, energy)
        {
        }
        
        public void CheckArmorOfFaith()
        {
            if (Health < 0.3 * MaxHealth)
            {
                Defence += Defence;
                Console.WriteLine("Armor  activated");
            }
        }
    }
}
