using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IMagicUnit
    {
        public int Energy{get; set;}

        public int RemovedEnergy { get => MaxEnergy - Energy; }
        public int MaxEnergy { get; set; }


    }
}
