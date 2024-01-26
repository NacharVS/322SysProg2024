using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal interface IHealingSkill
    {
        public void Heal(IHealthControl healthControl);
    }
}
