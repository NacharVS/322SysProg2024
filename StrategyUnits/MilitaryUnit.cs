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

        public int Defence
        {
            get { return _defence; }
            set { _defence = value; }
        }

        public void InflictedDamage
        {
            
        }
        public MilitaryUnit(int health, string? name) : base(health, name)
        {

        }
    }
}
