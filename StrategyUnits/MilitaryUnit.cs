﻿using System;
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

        public int Damage
        {
            get { return _damage; } // Отображает при вызове
            set  // Происходит при каком-то изменении
            {
                if (value < 0)
                {
                    _damage = 0;
                }
                else if (_damageMax < value)
                {
                    _damage = _damageMax;
                }
                else
                {
                    _damage = value;
                }
            }
        }

        public Defence()
        {

        }
    }
}
