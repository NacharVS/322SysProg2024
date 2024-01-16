using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {
        private int _damage;
        private int _damageMax;
        private int _damageMin;
        private Random random = new Random();

        public int RandomDamage()
        {
            return random.Next(_damageMin, _damageMax);
        }

        public void InflictDamage(Unit unit)
        {
            _damage = RandomDamage();
            unit._health -= _damage;
        }

    }
}
