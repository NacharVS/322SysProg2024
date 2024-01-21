using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zeclot : Palladin
    {
        public Zeclot(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
            OnHealthDecreased += ArmorOfFaiths;
            OnHealthIncreased += ArmorOfFaiths;
        }
        public bool ArmorFaith;
        public void ArmorOfFaiths(int health)
        {
            if (health <= MaxHealth * 0.3)
            {
                if (!ArmorFaith)
                {
                    ArmorFaith = true;
                    Defence *= 2;
                }
            }
            else
            {
                if (ArmorFaith)
                {
                    ArmorFaith = false;
                    Defence /= 2;
                }
            }
        }
    }
}
