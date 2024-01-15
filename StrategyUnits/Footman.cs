namespace StrategyUnits
{
    internal class Footman : Unit
    {
        private int _damage;

        public int Damage
        {
            get { return _damage; }
            set { _damage = value; }
        }

        public Footman() : base(60, "Footman")
        {
            _damage = 7;
        }

        public void InflictDamage(Unit unit)
        {
            if (Dead)
            {
                Console.WriteLine("Атака не может быть проведена - атакующий персонаж мертв");
            }
            else if (unit.Dead)
            {
                Console.WriteLine("Атака не может быть проведена - персонаж, которого атакуют, мертв");
            }
            else
            {
                unit.Health -= _damage;
            }
        }
        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} Damage: {Damage} Health: {Health}/{MaxHealth}");    
        }
    }
}
