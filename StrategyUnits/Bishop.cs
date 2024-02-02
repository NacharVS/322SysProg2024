using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Bishop : Unit, IMilitaryUnit, IMagicUnit, IHealerUnit
    {
        public Bishop(int health, string? name, int defence, int minDamage, int maxDamage, int energy) : base(health, name, defence)
        {
            DamageMin = minDamage;
            DamageMax = maxDamage;
            EnergyMax = energy;
            Energy = energy;
        }

        public int DamageMin { get ; set; }
        public int DamageMax { get ; set; }
        public int Energy { get ; set ; }
        public int EnergyMax { get ; set; }
        private Random random = new Random();


        public delegate void HealDelegate(int Mana, int health, string BishopName, string UnitName);   
        public void Heal(IHealthControll unit)
        {
            if (unit.Alive is false)
            {
                Console.WriteLine( $"{Name}  умер.");
            }
            else
            {
                while (Energy >=2 && unit.Health != unit.HealthMax)
            {
                    unit.Health += 1;
                    Energy -= 2;
            }
                HealEvent?.Invoke(Energy, unit.Health, Name, unit.Name);
           
            }
            
        }
        public int AmountDamage()
        {
            return random.Next(DamageMin, DamageMax + 1);
        }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(AmountDamage());
        }


        public event HealDelegate HealEvent;
    }
}
