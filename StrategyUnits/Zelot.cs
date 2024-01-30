using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zelot : Paladin

    {
        public Zelot(int health, int maxhealth, int maxdamage, int mindamage, string? name, int defense, int mana) : base(health, maxhealth, maxdamage, mindamage, name, defense, mana)
        {
        }
        public void CheckArmorOfFaith()
        {
            if (Health < 0.3 * MaxHealth)
            {
                Defense += Defense;
                Console.WriteLine("Armor  activated");
            }
        }
    }
}