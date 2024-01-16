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
        private int _energy;
        public int MaxEnergy
        {
            get;
            private set;
        }
        
        public int mana
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
                    if (value > MaxEnergy)
                        _energy = MaxEnergy;
                    else
                        _energy = value;
                }
            }
        }
       
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }

        public Bishop() : base(30, "Bishop")
        {
            _heal = 7;
            _energy = 60; 
            MaxEnergy = mana;
        }

        public void InflictHeal (Unit unit)
        {
         
            while(unit.Health < MaxEnergy  & mana >= 2)
            {
          unit.Health += 1;
            mana -= 2;
            }
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: { Health} MaxHealth: {MaxHealth} Energy:{mana} MaxEnergy:{MaxEnergy} ");
        }
    }
}
