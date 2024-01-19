using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        public Bishop(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {
        }

        public void Heal(Unit unit)
        {
            if (!IsAlive)
            {
                base.ShowInfo("Не может никого лечить т.к. мертв.");
                return;
            }

            if (!unit.IsAlive)
            {
                Console.WriteLine($"{Name} не может лечить {unit.Name}, т.к. {unit.Name} мертв.");
                return;
            }

            if (Mana >= 2)
            {
                double lives = Math.Min(unit.RemovedHealth, Mana / 2);
                unit.GetHeal(lives);
                Mana -= Convert.ToInt32(Math.Ceiling(lives * 2));
                Console.WriteLine($"{Name} восстановил {unit.Name} {lives} жизней.");
            }
            else
            {
                Console.WriteLine($"У {Name} нет энергии для лечения {unit.Name}");
            }
        }

        public override void ShowInfo (string additionalText = "") 
        {
            base.ShowInfo($"Энергия: {Mana}/{MaxMana}. {additionalText}");
        }
    }
}
