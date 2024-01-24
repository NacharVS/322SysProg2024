using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : Unit, IDefenced, IMilitaryUnit, IMagicUnit
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        private Random random = new Random();

        public void SaintBow(Unit unit)
        {
            if (Energy >= 20)
            {
                unit.GetDamage(20);
                Energy -= 20;

            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }

        }


        public Paladin(int health, int defence, string? name, int maxdamage, int mindamage, int energy) : base(health, name )
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            Energy = energy;
            Defence = defence;
        }
        public void InflictDamage(IHealController unit)
        {
            unit.GetDamage(CountDamage());
        }

        public double CountDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }
        public override void GetDamage(double damage)
        {
            if (damage - Defence > 0)
            {
                base.GetDamage(damage - Defence);
            }
        }


        public void Prayer()
        {
            if (Energy >= 10)
            {
                Energy -= 10;
                GetHeal(20);
            }
            else
            {
                Console.WriteLine("Недостаточно энергии");
            }
        }
    }
}
