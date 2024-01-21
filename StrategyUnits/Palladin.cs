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
        public Palladin(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
        }

      
        public void MagicKick(Unit unit)
        {
           
           if (Mana >= 3)
            {
                Mana -= 3;
                unit.GetDamage(AmountDamage() * 2);
                
            }
        }
        public void Prayer()
        {
            if (Mana >= 10)
            {
                GetHeal(20);
                Mana -= 10;
                
            }
        }
        
    }
}
  //public void AttackMag(MagicUnit magicunit)
        //{
        //    while(magicunit.EnergyPoints > 0)
        //    {
        //        magicunit.Health -= _damageMagic;
        //        EnergyPoints--;
        //    }
        //}