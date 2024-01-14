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
                Console.WriteLine("Действие не может быть выполнено - персонаж мертв");
            }
            else
            {
                unit.Health -= _damage;
            }
        }

    }
}
