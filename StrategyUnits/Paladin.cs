using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        private int _energyCost;
        public int EnergyCost
        {
            get { return _energyCost; }
            set { _energyCost = value; }
        }

        public Paladin() : base(40, "Paladin", 7, 10, 40)
        {

        }

        public void SacredBlow(Unit unit)
        {
            EnergyCost = 20;
            int damage = 20;
            if (Dead)
            {
                Console.WriteLine("Атака не может быть проведена - атакующий персонаж мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine("Атака не может быть проведена - персонаж, которого атакуют, мертв");
            }
            else
            {
                if (unit.Defence >= damage)
                {
                    Console.WriteLine("Противник заблокировал атаку");
                }
                else
                {
                    unit.Health -= (damage - unit.Defence);
                }
                Energy -= EnergyCost;
            }
        }
    }
}
