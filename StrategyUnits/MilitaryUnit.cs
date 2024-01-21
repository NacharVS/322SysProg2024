namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {

 
        private int _damageMax;
        private int _damageMin;
        private Random random = new Random();

        public int DamageMin 
        { 
            get { return _damageMin; } 
            set { _damageMin = value; } 
        }
        public int DamageMax 
        { 
            get { return _damageMax; } 
            set { _damageMax = value; } 
        }
        public MilitaryUnit(int health, string? name, int _DamageMax, int _DamageMin, int defense) : base(health, name, defense)
        {
            _damageMax = _DamageMax;
            _damageMin = _DamageMin;
        }

        public virtual int RandomDamage()
        {
            return random.Next(DamageMin,DamageMax);
        }

        public void InflictDamage(Unit unit)
        {
            unit.TakeDamage(this.RandomDamage());
        }

      
    }
}
