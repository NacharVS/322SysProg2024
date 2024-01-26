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
        public int EnergyCost;
        public Bishop() : base(20, "Bishop", 10, 1, 3, 60)
        {
            
        }

        public void InFlickHeal(Unit unit)
        {
            if (Dead)
            {
                Console.WriteLine($"Исцеление не может быть проведено - исцеляющий персонаж, {Name}, мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine($"Исцеление не может быть проведено - персонаж, {unit.Name}, которого исцеляют, мертв");
            }
            else
            {
                if (unit.MaxHealth-unit.Health <= Energy / 2)
                {
                    EnergyCost = unit.MaxHealth - unit.Health;
                    unit.Health += EnergyCost;
                    Energy -= EnergyCost*2;
                }
                else
                {
                    EnergyCost = Energy / 2;
                    unit.Health += EnergyCost;
                    Energy -= EnergyCost*2;
                }
            }
        }
        
    }
}
