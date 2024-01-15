using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int MinDamage;
        private int MaxDamage;
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
                int damage = RandomDamage();
                unit.GetDamage(damage);
                Console.WriteLine($"{Name} ударил {unit.Name} на {damage} урона, защита юнита: {unit.Defense}.");
            }
            else
            {
                Console.WriteLine($"{Name} is dead");
            }
            
        }
        public int RandomDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }
    }
}
