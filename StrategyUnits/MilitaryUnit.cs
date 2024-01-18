using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damageMIN;
        private int _damageMAX;
        private int _defence;

        public MilitaryUnit(int health, string? name) : base(health, name)
        {
        }

        public int DamageMinimum
        {
            get { return _damageMIN; }
            set { _damageMIN = value; }
        }
        public int DamageMaximum
        {
            get { return _damageMAX; }
            set { _damageMAX = value; }
        }



        public virtual void InflictedDamage(Unit unit)
        {
            //    Random random = new Random();
            //    unit.Health -= random.Next(_damageMIN, _damageMAX);
            unit.GetsDamage(DamageMaximum);
        }
    }
}

