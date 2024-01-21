namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman", true,100, 4,10)
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
        public void Rage(Footman footman1)
        {
            if(footman1.MaxHealth *0.5 < footman1.Health) footman1
        }

    }
}
