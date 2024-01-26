namespace StrategyUnits
{
    internal class Peasant : Unit, IHealthControl
    {
        public Peasant() : base(30, "Peasant")
        {
            
        }


        public void TakeDamage(double Damage)
        {
            
                health -= Damage;
            
        }
    }
}
