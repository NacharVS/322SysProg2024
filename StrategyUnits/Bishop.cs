using StrategyUnits;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit 
    {
        private int _heal;
        public void Heal(Unit unit)
        {
             if (!IsAlive)
            {
                base.ShowInfo("умер");
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
                 unit.GetHeal(lives);
                 mana -= Convert.ToInt32(Math.Ceiling(lives * 2));
                 Console.WriteLine($"{Name} восстановил {unit.Name} {lives} жизней.");
            }
            else
            {
                 Console.WriteLine($"У {Name} нет энергии для лечения {unit.Name}");
            }
        }

        public Bishop(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {
            _heal = 7;
        }
    }
}
