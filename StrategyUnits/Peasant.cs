namespace StrategyUnits
{
    internal class Peasant : Unit, IHealthControl, IArmoredUnit
    {
        public Peasant() : base(30, "Peasant")
        {
            
        }

        public int Armor { get; set; }

        public void TakeDamage(double Damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                health -= Damage;
            }
        }
    }
}
