using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Grunt : Unit,IHealthController, IBattleUnit, IArmoredUnit
    {
        public Grunt(int health, int damage, int armor)
        {
            Health = 80;
            MinDamage = 10;
            MaxDamage = 20;
            Armor = 2;
        }

        public int Health { get; set; }
    
        public int Armor { get ; set ; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }

        public void Attack(IHealthController unit)
        {
            Random random = new Random();
            unit.TakeDamage(random.Next(MinDamage, MaxDamage));
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }
    }
}
