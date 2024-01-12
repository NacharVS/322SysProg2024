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

        public Footman() : base(60, "Footman")
        {
            if (IsAlive)
            {
                _damage = 0;
            }
            else
            {
                _damage = 7;
            }
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;   
        }

    }
}
