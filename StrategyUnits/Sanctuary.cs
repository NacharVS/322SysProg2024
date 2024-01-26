﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Sanctuary
    {
        private int _energyReserve;
        private int _energyCapacity;
        public int energyReserve
        {
            get { return _energyReserve; }
            set { _energyReserve = value; }
        }
        public int energyCapacity
        {
            get { return _energyCapacity; }
        }
        public Sanctuary()
        {
            _energyReserve = 90;
            _energyCapacity = 350;
        }
        public void refill(IMagicUnit unit)
        {
            while(unit.EnergyPoints + 10 < unit.EnergyLimit && energyReserve > 0)
            {
                unit.Refill(10);
                energyReserve -= 1;
            }

        }
    }
}
