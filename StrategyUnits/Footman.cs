namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        public Footman(int health, int mindamage, int maxdamage, int defense, string? name) : base(health,mindamage,maxdamage, defense, name)
        {
            
        }
        public bool Rage()
        {
            return (RemovedHealth <= MaxHealth * 0.5);
        }
        public override double CountDamage()
        {

            double damage = base.CountDamage();
            if(Rage())
            {
                damage *= 1.5;
            }
                return damage;
        }
    }
}
