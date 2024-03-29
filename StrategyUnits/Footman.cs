﻿namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public Footman(int health, string? name, int damage) : base(health, name)
        {
            _damage = damage;
        }

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
            unit.Health -= _damage;
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} damage: {_damage}. {Health}/{MaxHealth}");
        }
    }
}
