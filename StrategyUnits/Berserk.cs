using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Footman
    {
        public Berserk(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }
        public void Frenzy(Unit unit)
        {
            int damage = AmountDamage();
            if (Health <= MaxHealth * 0.3)
            {
                damage *=3;
            }
        }
        public override void GetHeal(int CountHeal)
        {
            if (!(Health <= MaxHealth * 0.3))
            {
                base.GetHeal(CountHeal);
            }
        }
    }
}
