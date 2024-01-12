using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _energy;

        public int Energy
        {
            get { return _energy; }
            set 
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (value > MaxHeath)
                    {
                        _energy = MaxHeath;
                    }
                    else
                    {
                        _energy = value;
                    }
                }
            }
        }

        public int MaxEnergy;

        public Bishop() : base(50, "Bishop")
        {
            _energy = 3;
            MaxEnergy = Energy;
        }

        public void Heal(Unit unit)
        {
            if (!IsAlive)
            {
                base.ShowInfo("Не может никого лечить так как мертв.");
                return;
            }

            if (!unit.IsAlive)
            {
                Console.WriteLine($"{Name} не может лечить {unit.Name}, т.к {unit.Name} мертв.");
                return;
            }

            if (_energy >= 2)
            {
                int lives = Math.Min(unit.RemovedHealth, Energy / 2);
                unit.Health += lives;
                Energy -= lives * 2;
            }
            else
            {
                Console.WriteLine($"У {Name} нет энергии для лечения {unit.Name}");
            }
        }

        public override void ShowInfo (string additionalText = "") 
        {
            base.ShowInfo($"Энергия: {_energy}. {additionalText}");
        }
    }
}
