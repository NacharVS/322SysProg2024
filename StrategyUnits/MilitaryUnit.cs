namespace StrategyUnits
{
    internal class MilitaryUnit: Unit
    {

        private int _damage;
        private int _damageMax;
        private int _damageMin;
        private Random random = new Random();

        public MilitaryUnit(int health, string? name, int _DamageMax, int _DamageMin, int defense) : base(health, name, defense)
        {
            _damageMax = _DamageMax;
            _damageMin = _DamageMin;
        }

        public int RandomDamage()
        {
            return random.Next(_damageMin, _damageMax);
        }

        public void InflictDamage(Unit unit)
        {
            _damage = RandomDamage();
            unit._health -= _damage;
        }

      
    }
}
