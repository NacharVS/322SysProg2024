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
                Console.WriteLine("Prayer activated");
            }
            else
            {
                Console.WriteLine("Not enough mana");
            }
        }

        public void SaintHeal()
        {
            if (Energy>=25)
            {
                _defence += 3;
                Energy -= 25;
            }
            else
            {
                Console.WriteLine("Not enough");
            }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($" Health: {Health}   Min demage: {_mindamage} Max demage: {_maxdamage} Unit: {Name} Defence: {_defence} Energy: {Energy} altar: {_altar}");
        }
        
    }
}


