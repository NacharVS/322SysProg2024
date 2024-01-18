using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        //public void AttackMag(MagicUnit magicunit)
        //{
        //    while(magicunit.EnergyPoints > 0)
        //    {
        //        magicunit.Health -= _damageMagic;
        //        EnergyPoints--;
        //    }
        //}
        public void MagicKick(Unit unit)
        {
           
            EnergyPoints -= 20;
            DamageMinimum = 1;
            DamageMaximum = 8;
            InflictedDamage(unit);
        }

        public Palladin(int health, string? name) : base(health, name)
        {
            
            EnergyPoints = 50;
            energyLimit = 70;
            Defence = 3;
            DamageMinimum = 1;
            DamageMaximum = 8;
        }

    }
}
