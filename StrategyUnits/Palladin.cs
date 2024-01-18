using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Palladin : MagicUnit
    {
        private int _saintRow;
        public int SaintRow { get { return _saintRow; } set { _saintRow = value; } }
        public Palladin(int health, string? name, bool life, int defence, int maxddamage, int mindamage) : base(health, name, life, defence, maxddamage, mindamage)
        {
            _saintRow = 5;
        }

        public void HitSaintRow(Unit unit)
        {
            unit.Defence += _saintRow;
        }

    }
}
