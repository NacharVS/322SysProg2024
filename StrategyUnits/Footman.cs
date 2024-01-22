namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damage;



        public Footman() : base(60, 100, "Footman", 7, 1)
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

