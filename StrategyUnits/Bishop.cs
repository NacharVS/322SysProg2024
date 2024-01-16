using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : MagicUnit 
    {
        private int _heal;
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Bishop() : base(32, "Bishop",10,3,7)
        {
            _heal = 7;
        }

        public void InflictHeal (Unit unit)
        {
         
            while(unit.Health < unit.MaxHealth  & mana>=2)
            {
             unit.Health += 1;
            mana -= 2;
            }
        
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: { Health} MaxHealth: {MaxHealth} Energy:{mana} MaxEnergy:{MaxMana} ");
        }
    }
}
