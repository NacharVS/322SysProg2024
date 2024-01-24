using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IFrenzy
    {
        public bool IsFrenzy { get; set; }

        public void Frenzy();
    }
}
