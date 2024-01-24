namespace StrategyUnits
{
    internal class Throll : IHealthController, IBattleUnit
    {
        public Throll() 
        {
            Health = 120;
            Damage = 10;
        }

        public int Health { get; set; }
        public int Damage { get; set; }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(Damage);
        }

        public void TakeDamage(int damage)
        {
            Health -= damage;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }
    }
}
