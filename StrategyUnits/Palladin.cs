using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin(int health, string? name) : base(health, name)
        {
            DamageMin = 1;
            DamageMax = 8;
            EnergyPoints = 60;
            energyLimit = 100;
            Defence = 4;
        }
        public void SaintSword(Unit unit)
        {
            DamageMin = 10;
            DamageMax = 10;
            InflictDamage(unit);
            EnergyPoints -= 30;
            DamageMin = 1;
            DamageMax = 8;
        }
        public void Prayer()
        {
            if(EnergyPoints > 10)
            {
                EnergyPoints -= 10;
                Health += 20;
            }
        }
    }
}
