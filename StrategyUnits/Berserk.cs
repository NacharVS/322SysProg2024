using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : MilitariUnit
    {
        public Berserk(int health,int maxhealth, int mindamage, int maxdamage, string? name, int defence) : base(health,maxhealth, mindamage, maxdamage,  name, defence)
        {
        }
        private bool berserkmode;
        public void Frenzy()
        {
            if (Health < 0.3 * MaxHealth)
            {
                berserkmode = true;
                Console.WriteLine(" frenzy");
            }
        }
    }
}