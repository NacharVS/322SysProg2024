using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar
    {
        public int energy { get; set; }
        public Bishop(int intialenergy)
        {
            energy = intialenergy;
        }
        public void EnterAltar(Altar altar)
        {
            if (altar.CanRestoreEnergy)
            {
                energy =10;
            }
        }
        public class Altar
        {
            public bool CanRestoreEnergy()
            {
                return true;
            }
        }
        
    }
}
