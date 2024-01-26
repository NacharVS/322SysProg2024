using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Paladin : Unit, IArmored, IMilitary, IMagic
    {
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                    {
                        _mana = MaxMana;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }

        public int MaxMana { get; set; }

        private int _mana;
        private Random random = new Random();

        public Paladin(int health, string? name, int minDamage, int maxDamage, int armor, int mana) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
            MaxMana = mana;
            Mana = mana;
        }

        public void SaintJuglement(IHealthController unit)
        {
            if (Mana >= 3)
            {
                unit.TakeDamage(CountDamage() * 2);
                Mana -= 3;
            }
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public void Prayer()
        {
            if(Mana >= 10) 
            {
                Mana -= 10;
                TakeHeal(20);
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно маны для заклинания Prayer");
            }
        }

        public override void TakeDamage(double damage)
        {
            if(damage - Armor > 0)
            {
                base.TakeDamage(damage - Armor);
            }
        }
    }
}
