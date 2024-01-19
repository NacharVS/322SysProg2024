using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        protected int MinDamage;
        protected int MaxDamage;
        private Random random = new Random();

        public MilitaryUnit(int health,int mindamage, int maxdamage,int defense, string? name) : base(health, defense ,name)
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
        }
        public void InflictDamage(Unit unit)
        {
            if (IsAlive)
            {
                double damage = CountDamage();
                unit.GetDamage(damage);
                Console.WriteLine($"{Name} attacked {unit.Name} for {damage} damage, unit defense: {unit.Defense}.");
            }
            else
            {
                Console.WriteLine($"{Name} is dead!");
            }
            
        }
        public virtual double CountDamage()
        {
            
            return random.Next(MinDamage, MaxDamage);
        }
        public override void ShowInfo(string additionalText = "")
        {
            base.ShowInfo($"Damage: {MinDamage}-{MaxDamage}. " + additionalText);
        }
    }
}
