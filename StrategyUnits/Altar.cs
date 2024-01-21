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

        public Altar(int health, string? name, int Defense, int _DamageMax, int _DamageMin) : base(health, name, Defense, _DamageMax, _DamageMin)
        {
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
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
