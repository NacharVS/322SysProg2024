using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Peasant : Unit, IHealthController
    {
        public Peasant(int health, string? name, int defence) : base(health, name)
        {
        }
        public int Damage { get; set; }
        public int MaxHealth { get; set; }
        public int health { get; set; }
        public void TakeDamage(int damage)
        {
            health -= Damage;
        }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }
    }
}
