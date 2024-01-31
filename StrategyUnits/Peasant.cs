using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Peasant : Unit,IHealthController
    {
        public Peasant(int health, string? name, int defence) : base(health, name)
        {
        }

        public void TakeDamage(int damage)
        {
            health -= Damage;
        }

       
    }
}
