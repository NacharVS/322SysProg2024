using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal interface IHealthController
    {

        public int Health { get; set;}
        public int MaxHealth { get; set;}
        public void TakeDamage(int damage);
        public void TakeHeal(int healAmount);
    }
}
