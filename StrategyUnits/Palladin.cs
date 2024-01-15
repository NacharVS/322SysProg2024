using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        Random random = new Random(); 
        public Palladin() : base(80, "Palladin", 4, 6, 5, 100)
        {
        }

        private int _demage;
        public void MagicDemage( Unit unit)
        {
           _demage = random.Next(10, 20);
            if(_demage * 3 > Energy)
            {
                unit.Health -=  * 3; 
            }
           Energy -= _demage *20;
            
        }
    }
}
