using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IFaith
    {
        public bool IsArmorFaith { get; set; }

        public void ArmorFaith(int health);
    }
}
