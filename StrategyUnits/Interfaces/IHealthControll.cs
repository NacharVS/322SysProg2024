using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealthControll
    {
        public int Health { get; set; }
        public int HealthMax { get; set; }
        public bool Alive { get; set; }
        public void TakeDamage(int damage);
        public int RemoveHealth => HealthMax - Health;
        public void TakeHeal(int healAmount);
    }
}
