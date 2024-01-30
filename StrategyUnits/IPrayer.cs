using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IPrayer
    {
        public bool prayerBool { get; set; }
        public void Prayer();
    }
}
