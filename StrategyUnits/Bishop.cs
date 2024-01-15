using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {

        public Bishop() : base(50, "Bishop", 1, 3, 0, 12)
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
                int lives = Math.Min(unit.RemovedHealth, Mana / 2);
                unit.GetHeal(lives);
                Mana -= lives * 2;
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
