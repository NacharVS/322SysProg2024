using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zealot : Paladin
    {
        public Zealot(int health, int mindamage, int maxdamage, int defense, int energy, string? name) : base(health, mindamage, maxdamage, defense, energy, name)
        {
            HealthIncreasedEvent += LowHP;
            HealthDecreasedEvent += LowHP;
        }
        private void LowHP(double health)
        {
            if (health < MaxHealth *0.3 && !ArmorOfFaith)
            {
                ArmorOfFaith = true;
                Defense += Defense;
            }
            else if (health > MaxHealth *0.3&& ArmorOfFaith)
            {
                ArmorOfFaith = false;
                Defense -= Defense/2;
            }

        }
        private bool ArmorOfFaith;
    }
}
