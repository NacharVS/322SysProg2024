using System;
using System.Security.Cryptography;

namespace StrategyUnits
{
    internal class Footman : Unit, IHealthControl, IArmoredUnit, IBattleUnit, IRage
    {
        
        Random random = new Random();
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int Armor { get; set; }
        

        public bool IsRage { get; set; }

        public Footman(int health, string name, int damagemin, int damagemax, int defence) : base(health, name)
        {
            DamageMin = damagemin;
            DamageMax = damagemax;
            Armor = defence;
        }

        public Footman() : base(60, "Footman")
        {
            DamageMin = 1;
            DamageMax = 10;
            Armor = 6;
            Random random = new Random();
            
        }
        public void Rage()
        {
            IsRage = true;
        }
        
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} damage: {DamageMin}/{DamageMax}. {health}/{maxHealth}");
        }

        public void InflictDamage(IHealthControl unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            if (!IsRage)
                return random.Next(DamageMin, DamageMax);
            else
                return random.Next(DamageMin, DamageMax);
        }

        public void TakeDamage(double Damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                health -= Damage;
            }
        }
    }
}
