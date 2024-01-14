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
        
        public int energy
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

        public Bishop() : base(32, "Bishop")
        {
            _heal = 7;
            _energy = 10; 
            MaxEnergy = energy;
        }

        public void InflictHeal (Unit unit)
        {
         
            while(unit.Health < MaxEnergy  & _energy>0)
          unit.Health = 1;
            energy -= 2;
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: { Health} MaxHealth: {MaxHealth} Energy:{energy} MaxEnergy:{MaxEnergy} ");
        }
    }
}
