using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zealot:Unit, IMilitaryUnit, IMagicUnit, IDefenced
    {
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        private Random random = new Random();

        public Zealot(int health, int defence, string? name, int maxdamage, int mindamage, int energy) : base(health, name)
        {
            HealthIncreasedEvent += CheckArmorOfFaith;
            HealthDecreasedEvent += CheckArmorOfFaith;
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            Energy = energy;
            Defence = defence;
        }

        private void CheckArmorOfFaith(double health)
        {
            if (health <= MaxHealth * 0.3 && !ArmorOfFaith)
            {
                ArmorOfFaith = true;
                Defence += Defence;
            }
            else if (health > MaxHealth * 0.3 && ArmorOfFaith)
            {
                ArmorOfFaith = false;
                Defence -= Defence / 2;
            }

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


        private bool ArmorOfFaith;
    }
}

