using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

        private bool IsCrazy => Health < MaxHealth * 0.3;

        private int Percent => IsCrazy ? 500 : 100;

        public void Frenzy(Unit unit)
        {
            InflictDamage(unit, Percent);
        }



        
    }
}
