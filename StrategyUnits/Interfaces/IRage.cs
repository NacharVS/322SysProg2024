﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IRage : IMilitoryUnit
    {
        public bool RageInfo { get; set; }
        public void Rage();
    }
}
