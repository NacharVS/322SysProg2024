using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{

   internal class Palladin : MagicUnit
    {
        public Palladin() : base(80, 4, 5, "Palladin", 6, 100)
        {
        }

        public Palladin(int health, int mindamage, int maxdamage, string? name, int defence, int energy) : base(health, mindamage, maxdamage, name, defence, energy)
        {
        }


        public void Mantra()
        {
            if (Energy >= 10)
            {
                Health += 40;
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                Energy -= 10;
                Console.WriteLine("Mantra activated, health increased to " + Health + ", mana decreased to " + Energy);
            }
            else
            {
                Console.WriteLine("Not enough mana for Mantra");
            }
        }
        public void InflictHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth)
            {
                unit.Health++;
                Fountain(2);
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Health: {Health}   Min damage: {_mindamage} Max damage: {_maxdamage} Unit: {Name} Defence: {_defence} Energy: {Energy} altar: {_altar}");
        }

    }
}