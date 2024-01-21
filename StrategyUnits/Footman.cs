namespace StrategyUnits
{
    internal class Footman : MiliteryUnit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }
        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
        }
        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
            
        }
        
        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }
        public override double CountDamage()
        {
            double damage = base.CountDamage();
            if (Rage())
            {
                damage *= 1.5;
            }
            return damage;
        }
    }
}
