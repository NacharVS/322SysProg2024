using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _healAmount;
        private int _energy;
        private int _healCost;

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public int HealAmount
        {
            get { return _healAmount; }
            set { _healAmount = value; }
        }

        public Bishop() : base(50, "Bishop")
        {
            _healAmount = 5;
            _energy = 3;
            _healCost = 1;
        }

        public void Heal(Unit unit)
        {
            if (_energy >= _healCost)
            {
                unit.Health += _healAmount;
                _energy -= _healCost;
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно энергии для лечения {unit.Name}");
            }
        }

        public override void ShowInfo (string additionalText = "") 
        {
            base.ShowInfo($"Энергия: {_energy}. {additionalText}");
        }
    }
}
