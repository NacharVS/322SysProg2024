using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : MagicUnit
    {
        public Paladin() : base(80,4,5,"Palladin",6,100)
        {
        }

        public Paladin(int health, int mindamage, int maxdamage, string? name, int defence, int energy) : base(health, mindamage, maxdamage, name, defence, energy)
        {
        }

        
        public void Prayer()
        {
            if (Energy >= 10)
            {
                Health += 20; 
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                Energy -= 10;
                Console.WriteLine("Prayer activated, health increased to " + Health + ", mana decreased to " + Energy);
            }
            else
            {
                Console.WriteLine("Not enough mana to perform Prayer");
            }
        }
        public void InflictHeal(Unit unit)
        {
            while (unit.Health < unit.MaxHealth)
            {
                unit.Health++;
                Altar(2);
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($" Health: {Health}   Min demage: {_mindamage} Max demage: {_maxdamage} Unit: {Name} Defence: {_defence} Energy: {Energy} altar: {_altar}");
        }
        
    }
}


