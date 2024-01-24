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

        private bool IsFrenzy;

        public void Frenzy() 
        {
            if(Health <= MaxHealth * 0.3)
            {
                IsFrenzy = true;
            }
        }

        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (IsFrenzy)
                damage *= 3;
            return damage;
        }

        public override void TakeHeal(double healAmount)
        {
            if(!IsFrenzy)
                base.TakeHeal(healAmount);
        }
    }
}
