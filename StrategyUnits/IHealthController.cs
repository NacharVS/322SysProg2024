using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealthController
    {
        public bool Dead { get; set; }
        public int Health { get; set; }
        public int Defence { get; set; }
        public string? Name {  get; set; }

        public void TakeDamage(int damage);

        public void TakeHeal(int healAmount);
    }
}
