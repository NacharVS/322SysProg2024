using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MiliataryUnit : Unit
    {
        protected int MinDamage;
        protected int MaxDamage;

        private Random random = new Random();

        public MiliataryUnit(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, defence)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
        }

        public void InflictDamage(Unit unit)
        {
            if (IsAlive)
            {
                int damage = RandomDamage();
                unit.GetDamage(damage);
                Console.WriteLine($"{Name} нанес {unit.Name} {damage} урона.(Зашита {unit.Defence})");
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать т.к. умер.");
            }
        }

        public int RandomDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public override void ShowInfo(string additionalText = "")
        {
            base.ShowInfo($"Урон: {MinDamage}-{MaxDamage}. " + additionalText);
        }
    }
}
