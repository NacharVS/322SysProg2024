using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit, IHealthController, IArmoredUnit
    {
        private int _heal;
        private int mana;

        public int Health {get;set;}
        public int Armor {get;set;}
       public int MaxHealth { get;set;}
        public int MaxMana { get ; set ; }
        public int Damage { get;  set; }
        object IHealthController.Name { get ; set ; }


        public void Heal(IHealthController unit)
        {
            unit.TakeHeal(44);
            if (!IsAlive)
            {
                base.ShowInfo();
                Console.WriteLine("умер");
                return;
            }

            if (!unit.IsAlive)
            {
                Console.WriteLine($"{Name} не может лечить {unit.Name}, т.к. {unit.Name} мертв.");
                return;
            }

            if (mana >= 2)
            {
                double lives = Math.Min(unit.RemovedHealth, mana / 2);
                unit.GetHeal((int)lives);
                mana -= Convert.ToInt32(Math.Ceiling(lives * 2));
                Console.WriteLine($"{Name} восстановил {unit.Name} {lives} жизней.");
            }
            else
            {
                Console.WriteLine($"{Name} нет энергии для лечения {unit.Name}");
            }
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(Damage);
        }

        public Bishop(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {
            _heal = 7;
        }
    }
}

