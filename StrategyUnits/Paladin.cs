﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {
        }

        public void SaintJuglement(Unit unit)
        {
            if (Mana >= 3)
            {
                unit.GetDamage(CountDamage() * 2);
                Mana -= 3;
            }
        }
    }
}
