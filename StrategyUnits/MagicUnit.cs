using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit: MilitaryUnit
    {
        public int _MP;
        public int _MaxMP;

        public MagicUnit(int health, string? name, int _DamageMax, int _DamageMin) : base(health, name, _DamageMax, _DamageMin)
        {
            _MP = 60;
        }

        public int MP
        {
            get { return _MP; } // Отображает при вызове
            set  // Происходит при каком-то изменении
            {
                if (value < 0)
                {
                    _MP = 0;
                }
                else if (_MaxMP < value)
                {
                    _MP = _MaxMP;
                }
                else
                {
                    _MP = value;
                }
            }
        }
    }
}
