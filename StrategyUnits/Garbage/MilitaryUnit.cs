using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Garbage
{
    internal class MilitaryUnit : Unit
    {
        private int _damageMin;
        private int _damageMax;
        Random random = new Random();
        public MilitaryUnit(int health, string name) : base(health, name)
        {

        }
        public int DamageMin { get { return _damageMin; } set { _damageMin = value; } }
        public int DamageMax { get { return _damageMax; } set { _damageMax = value; } }
        public void InflictDamage(Unit unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public virtual double CountDamage()
        {
            return random.Next(DamageMin, DamageMax);
        }
    }
}
