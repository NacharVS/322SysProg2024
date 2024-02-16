using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : Unit, IMagicUnit, IPrayer, ISaintHeal, IHealthControl
    {
        Random random = new Random();
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defence { get; set; }
        public int damaged { get; set; }
        public Paladin(int health, int mindamage, int maxdamage, string name, int defence, int energy) : base(health, name)
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            Defence = defence;
            Energy = energy;
        }

        public int RandomDamage(int MinDamage, int MaxDamage)
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage(MinDamage, MaxDamage));
        }


        public void Prayer()
        {
            if (Energy >= 10)
            {
                Health += 20; 
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                Energy -= 10;
                Console.WriteLine("Prayer activated");
            }
            else
            {
                Console.WriteLine("Not enough mana");
            }
        }

        public void SaintHeal()
        {
            if (Energy>=25)
            {
                Defence += 3;
                Energy -= 25;
            }
            else
            {
                Console.WriteLine("Not enough");
            }
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Energy: {Energy} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence}");
        }
    }
}


