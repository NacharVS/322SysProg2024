using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zealot : Paladin
    {
        public bool CheackArmor = false;
        public void ArmorOfFaith()
        {
            if (Dead)
            {
                Console.WriteLine($"Невозможно выполнить это действие - персонаж, {Name}, мертв");
            }
            else
            {
                if (Health <= (double)MaxHealth / 100 * 30 && !CheackArmor)
                {
                    CheackArmor = true;
                    Defence += Defence;
                }
                else if (Health > (double)MaxHealth / 100 * 30 && CheackArmor)
                {
                    Defence -= Defence;
                    CheackArmor = false;
                }
            }
        }
    }
}
