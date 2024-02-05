using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class IHealthControl
    {
        public int Health { get; set; }
        public int MaxHealth { get; set; }

        public void TakeDamage(Unit unit, int _damage);

        public void GetHealth(Unit unit, int _health);
    }
}
