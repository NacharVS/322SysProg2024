using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Paladin: MagicUnit
    {
        public Paladin() : base(50, 100, 30, 25, "Paladin", 15, 50)
        { 

        }

        public Paladin(int health, int maxhealth, int maxdamage, int mindamage, string? name, int defense, int mana) : base(health, maxhealth, maxdamage, mindamage, name, defense, mana)
        {
        }

        public void SaintMagic()
        {
            while (Health > 0 || mana >= 35)
            {
                Health += 25;
                mana -= 35;
            }
        }
        public void ShowInfo()
        {
            Console.WriteLine($" Health: {Health}   Min demage: {MinDamage} Max demage: {MaxDamage} Unit: {Name} Defence: {Defense} Energy: {mana}");
        }
        public void Prayer()
        {
            if (mana >= 10)
            {
                Health += 20;
                if (Health > MaxHealth)
                {
                    Health = MaxHealth;
                }
                mana -= 10;
                Console.WriteLine("Prayer activated");
            }
            else
            {
                Console.WriteLine("Not enough mana");
            }
        }


    }
}
