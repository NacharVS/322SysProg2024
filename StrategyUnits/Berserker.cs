using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Footman
    {
        private bool _frenzy = false;
        public Berserker(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence, minDamage, maxDamage)
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
                if (Health < (double)MaxHealth/100*30 && !_frenzy)
                {
                    _frenzy = true;
                    unit.TakeDamage(damage + damage*5);
                }
                else if (Health >= (double)MaxHealth / 100 * 30 && _frenzy)
                {
                    _frenzy = false;
                    unit.TakeDamage(damage);
                }

            }
        }
    }
}
