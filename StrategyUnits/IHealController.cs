using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealController
    {
        public double Health { get; set; }
        public int MaxHealth { get; set; }

        public double RemovedHealth => MaxHealth - Health;

        public void GetDamage(double damage);

        public void GetHeal(double healAmount);
    }
}

