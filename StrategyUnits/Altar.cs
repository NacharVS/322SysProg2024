using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Altar: MagicUnit
    {
        private int _energy;
        private int _energyMax;

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }

        public Altar() 
        {
            _energy = 1;
        }

        public void RestoreMp(MagicUnit magicUnit)
        {
           if(magicUnit._MP < magicUnit._MaxMP)
           {
                magicUnit._MP += 10;
           }
        }
        

    }
}
