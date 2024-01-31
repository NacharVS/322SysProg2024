﻿namespace StrategyUnits
{
    internal class Footman : Unit, IHealthController, IArmoredUnit, IBattleUnit, IRage
    {
        Random random = new Random();
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int Armor { get; set; }


        public bool IsRage { get; set; }

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

       
        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
        }
        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name)
        {

        }

        public void InflictDamage(Unit unit)
        {
            unit.TakeDamage(CountDamage());
        }
        public  double CountDamage()
        {
            if (!IsRage)
                return random.Next(DamageMin, DamageMax);
            else
                return random.Next(DamageMin, DamageMax);
        }

        public void TakeDamage(int damage)
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


