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
        public Altar(int intialEnergy)
        {
            energy = intialEnergy;
        }
        public void EnterAltar()
        {
            if (energy < 10)
            {
                RestoreEnergy();
            }
        }
  
        private void RestoreEnergy()
            {
            energy += 10;
        }
        
    }
}
