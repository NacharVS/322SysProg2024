using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : MilitaryUnit
    {
        public Berserk(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, mindamage, maxdamage, name, defence)
        {
        }
        private bool berserkmode;
        public void Frenzy()
        {
            if (Health < 0.3 * MaxHealth)
            {
                berserkmode = true;
                Console.WriteLine("Berserk is franzy");
            }
        }
    }
}
