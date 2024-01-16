using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

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

        public Bishop() : base(20, "Bishop", 10, 0, 60)
        {
            _hill = 1;
            _energyCost = 2;
        }

        public void InFlickHill(Unit unit)
        {
            if (Dead)
            {
                Console.WriteLine("Исцеление не может быть проведено - исцеляющий персонаж мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine("Исцеление не может быть проведено - персонаж, которого исцеляют, мертв");
            }
            else
            {
                while (unit.Health < unit.MaxHealth)
                {
                    if (Energy <= 0) { break; }
                    unit.Health += Hill;
                    Energy -= EnergyCost;
                }
            }
        }
        
    }
}
