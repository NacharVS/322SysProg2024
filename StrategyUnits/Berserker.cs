using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        public bool Frenzy() 
        {
            return Health <= MaxHealth * 0.3;
        }

        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (Frenzy())
                damage *= 3;
            return damage;
        }
    }
}
