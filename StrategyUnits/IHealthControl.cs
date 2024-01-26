using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealthControl
    {
        public Double health { get; set; }
        public Double maxHealth { get; set; }
        public void TakeDamage(double Damage);
        public void GetHeal(double heal);
    }
}
