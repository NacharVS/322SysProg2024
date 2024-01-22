﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        public Berserker(int health, string? name, int defence, int minDamage, int maxDamage) : base(70, "Berserker", 3, 10, 14)
        {

        }

        public void Frenzy(Unit unit)
        {
            int damage = RandomDamage;
            if (Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - атакующий персонаж, {Name}, мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - персонаж, {unit.Name}, которого атакуют, мертв");
            }
            else
            {
                if (Health < (double)MaxHealth/100*30)
                {
                    unit.TakingDamage(damage + damage*5);
                }
                else
                {
                    unit.TakingDamage(damage);
                }

            }
        }
    }
}
