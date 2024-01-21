namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, 100, 50, 50, "Footman",5)
        {
            _damage = 7;
        }

        public Footman(int health, int maxhealth, int mana, int MaxMana, string? name, int defense) : base(health, maxhealth, mana, MaxMana, name, defense)
        {
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }

    }
}
