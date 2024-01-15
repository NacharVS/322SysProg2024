﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Bishop : Unit
    {
        private int _heal;


        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }


        public Bishop() : base(25, 30, 40, 40, "Bishop")
        {
            _heal = 1;
        }

        public void InflictHeal(Unit unit)
        {
            while (unit.Health < unit._MaxHealth & _mana > 0 & _fountain > 2)
            {
                unit.Health += _heal;
                Fountain(2);
            }
        }
    }
}
