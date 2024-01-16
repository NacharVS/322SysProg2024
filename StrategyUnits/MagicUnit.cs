using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit: MiliteryUnit
    {

        private int _mana;
        public MagicUnit(int health, string? name, int _damangemax, int _damangemin,int mana) : base(health,name,_damangemax, _damangemin)
        {
            MaxMana = mana;
            _mana = mana;
        }
        public int MaxMana
        {
            get;
            private set;
        }

        public int mana
        {

            get
            {
                return _mana;
            }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                        _mana = MaxMana;
                    else
                        _mana = value;
                }
            }
        }
    }
}
