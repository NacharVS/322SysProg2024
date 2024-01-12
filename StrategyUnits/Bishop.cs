using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _heal;

        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }
        public Bishop() : base(25, "Bishop")
        {
            _heal = 7;
            Energy = 40;
            MaxEnergy = Energy;
        }
        public void InflictHeal(Unit unit)
        {
            unit.Health += _heal;
        }

        private int _energy;
        public int MaxEnergy;

        public int Energy
        {
            get
            {
                return _energy;
            }
            set
            {
                if (value < 0)
                {
                    _energy = 0;
                }
                else
                {
                    if (_energy > MaxHealth)
                        _energy = MaxHealth;
                    else
                        _energy = value;
                }
                _energy = value;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {MaxHealth} Energy:{Energy} MaxEnergy:{MaxEnergy}");
        }
    }
}
