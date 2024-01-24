namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damage;



        public Footman(int health, int defence, string? name, int maxdamage, int mindamage) : base(health, defence, name, maxdamage, mindamage)
        {
        }

        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
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

