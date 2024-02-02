using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : Unit, IArmoredUnit, IMilitaryUnit, IMagicUnit, ISaintKick, IPrayer
    {
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int Energy { get ; set; }
        public int EnergyMax { get ; set ; }

        

        private Random random = new Random();

        public Palladin(int health, string? name, int defence) : base(health, name, defence)
        {
        }

        public int AmountDamage()
        {
            return random.Next(DamageMin, DamageMax + 1);
        }
        public void SaintKick(IHealthControll unit)
        {
           
           if (Energy >= 3)
            {
                Energy -= 3;
                unit.TakeDamage(AmountDamage() * 2);
                
            }
        }
        public void Prayer()
        {
            if (Energy >= 10)
            {
                GetHeal(20);
                Energy -= 10;
                
            }
        }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(AmountDamage());
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