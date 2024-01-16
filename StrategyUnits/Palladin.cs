using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        public Palladin() : base(30,"Palladin",10,4,8,5)
        {
            
        }
    public void SaintRow(Unit unit)
        {
            while(unit.Health >0 & mana> 0)
            {
                unit.Health -= 2;
                mana += 2;    
            }
        }
    }
}
