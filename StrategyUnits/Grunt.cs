namespace StrategyUnits
{
    internal class Grunt : IHealthController, IBattleUnit, IArmoredUnit
    {
        public Grunt()
        {
            Health = 80;
            Damage = 5;
            Armor = 2;
        }

        public int Health { get; set; }
        public int Damage { get ; set ; }
        public int Armor { get ; set; }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage - Armor;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }
    }
}
