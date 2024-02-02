using StrategyUnits.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zeclot : Unit, IArmoredUnit, IMilitaryUnit, IMagicUnit, IFaith
    {
        public bool ArmorFaith;

        public Zeclot(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, defence)
        {
            DamageMin = minDamage;
            DamageMax = maxDamage;
            Defence = defence;
            Energy = energy;
        }

        public int DamageMin { get ; set; }
        public int DamageMax { get ; set; }
        public int Energy { get; set; }
        public int EnergyMax { get; set ; }

        public void ArmorOfFaiths(int health)
        {
            if (health <= MaxHealth * 0.3)
            {
                if (!ArmorFaith)
                {
                    Defence *= 2;
                }
            }
            else
            {
                if (ArmorFaith)
                {
                    Defence /= 2;
                }
            }
        }
        private Random random = new Random();
        public int AmountDamage()
        {
            return random.Next(DamageMin, DamageMax + 1);
        }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(AmountDamage());
        }

        
    }
}
