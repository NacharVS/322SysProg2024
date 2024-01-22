namespace StrategyUnits
{
    internal class Footman : MilitoryUnit
    {

        public Footman() : base(60, "Footman", 5, 14, 19)
        {
            
        }

        public void Rage(Unit unit)
        {
            int damage = RandomDamage;
            if (Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - атакующий персонаж, {Name}, мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine($"Атака не может быть проведена - персонаж, {unit.Name}, которого атакуют, мертв");
            }
            else
            {
                if (Health < MaxHealth / 2)
                {
                    unit.TakingDamage(damage+damage/2);
                }
                else
                {
                    unit.TakingDamage(damage);
                }
                
            }
        }
    }
}
