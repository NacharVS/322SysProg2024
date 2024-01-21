using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zeclot : Palladin
    {
        public Zeclot(int health, string name, int damagemin, int damagemax, int defence, int energy) : base(80, "Zeclot", 120, 60, 70, 60)
        {
        }

        public void Frenzy(Unit unit)
        {
            if(unit.Health < unit.Max_healt * 1.3)
            {
                unit.TakeDamage((int)(RandomDamage() * 5));
            }
        }

    }
}
