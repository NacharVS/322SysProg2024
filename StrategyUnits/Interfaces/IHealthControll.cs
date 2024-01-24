﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Interfaces
{
    internal interface IHealthControll
    {
        public int Health { get; set; }

        public void TakeDamage(int damage);

        public void TakeHeal(int healAmount);
    }
}
