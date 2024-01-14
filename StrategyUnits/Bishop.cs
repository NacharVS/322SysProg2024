using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit
    {
        private int _hill;
        private int _energyCost;

        public int Hill
        {
            get { return _hill; }
            set { _hill = value; }
        }

        public int EnergyCost
        {
            get { return _energyCost; }
            set { _energyCost = value; }
        }

        public Bishop() : base(20, "Bishop")
        {
            _hill = 1;
            _energyCost = 2;
            _energy = 60;
            MaxEnergy= _energy;
        }

        public void InFlickHill(Unit unit)
        {
            if (Dead || unit.Dead)
            {
                Console.WriteLine("Действие не может быть выполнено - персонаж мертв");
            }
            else
            {
                while (unit.Health < unit.MaxHealth)
                {
                    if (Energy <= 0) { break; }
                    unit.Health += _hill;
                    Energy -= _energyCost;
                }
            }
        }
        
    }
}
