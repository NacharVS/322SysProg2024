﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class IRandomDamgeController
    {
        int damaged { get; set; }
        public int RandomDamage(int MinDamage, int MaxDamage);
    }
}
