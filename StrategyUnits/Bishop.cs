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

            if (_energy >= 2)
            {
                int lives = Math.Min(unit.RemovedHealth, Energy / 2);
                unit.GetHeal(lives);
                Energy -= lives * 2;
            }
            else
            {
                Console.WriteLine($"У {Name} нет энергии для лечения {unit.Name}");
            }
        }

        public override void ShowInfo (string additionalText = "") 
        {
            base.ShowInfo($"Энергия: {_energy}/{MaxEnergy}. {additionalText}");
        }
    }
}
