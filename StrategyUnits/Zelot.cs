using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zelot : Palladin
    {
        private bool ArmorOfFaith;
        public Zelot(int health, string name, int damagemin, int damagemax, int defence, int energy) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Defence = defence;
            EnergyPoints = energy;
            energyLimit = energy;
        }
        private void CheckArmorOfFaith(double health)
        {
            if (health > MaxHealth * 0.3 && ArmorOfFaith)
            {
                ArmorOfFaith = false;
                Defence = Defence - Defence / 2;
            }
            else if (health <= MaxHealth * 0.3 && !ArmorOfFaith)
            {
                ArmorOfFaith = true;
                Defence = Defence * 2;
            }
        }
    }
}
