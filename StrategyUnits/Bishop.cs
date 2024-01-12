using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _hill;
        
        public int Hill
        {
            get { return _hill; }
            set { _hill = value; }
        }

        

        public Bishop() : base(20, "Bishop")
        {
            _hill = 1;
        }

        public void InFlickHill(MagicUnit magicUnit)
        {
            while (magicUnit.Health < magicUnit.MaxHealth)
            {
                if (magicUnit.Energy <= 0) { break; }
                magicUnit.Health += _hill;
                magicUnit.Energy -= 2;
            }
            
        }
    }
}
