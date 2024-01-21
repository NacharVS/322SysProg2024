using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitariUnit
    {
        public MagicUnit(int health, int maxhealth, int maxdamage, int mindamage, string? name, int defense,int mana) : base(health, maxhealth, maxdamage, mindamage, name,defense)
        {
            _MaxMana = mana;
            _mana = mana;
        }
        public int  MaxMana
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
