using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
    {
        internal class Zelot : Palladin
        {
            public Zelot(int health, int mindamage, int maxdamage, string? name, int defence, int energy) : base(health, mindamage, maxdamage, name, defence, energy)
            {
            }

            public void CheckArmorOfFait()
            {
                if (Health < 0.3 * MaxHealth)
                {
                    _defence += _defence;
                    Console.WriteLine("Armor  activated");
                }
            }
        }
    }