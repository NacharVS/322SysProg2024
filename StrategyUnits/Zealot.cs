﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zealot:Paladin
    {
        public Zealot(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence, energy)
        {

        }

        private void CheckArmorOfFaith(double health)
        {
            if (health <= MaxHealth * 0.3 && !ArmorOfFaith)
            {
                ArmorOfFaith = true;
                Defence += Defence;
            }
            else if (health > MaxHealth * 0.3 && ArmorOfFaith)
            {
                ArmorOfFaith = false;
                Defence -= Defence / 2;
            }

        }

        private bool ArmorOfFaith;
    }
}

