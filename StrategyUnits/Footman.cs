﻿namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (IsAlive)
            {
                unit.Health -= _damage;
            }
            else
            {
                Console.WriteLine($"{Name} не может атаковать т.к. умер.");
            }
        }

    }
}
