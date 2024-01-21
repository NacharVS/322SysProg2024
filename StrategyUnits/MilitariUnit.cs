using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitariUnit : Unit
    {
        public int MaxDamage
        { get; set; }
        public int MinDamage
        { get; set; }
        Random random = new Random();
        public MilitariUnit(int health, int maxhealth, int maxdamage, int mindamage, string? name, int defense) : base(health, maxhealth, maxdamage, mindamage, name,defense)
        {
            MaxDamage = maxdamage;
            MinDamage = mindamage;
        }
        private int damage;
        public void Damage(Unit unit)
        {
            int countdamage = random.Next(MinDamage, MaxDamage);
            countdamage -= unit.Defense;
            unit.Health -= Math.Max(0, countdamage);
        }

    }
}
