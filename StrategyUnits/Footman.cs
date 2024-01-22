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

        public Footman() : base(60, 25, 25, "Footman", 4)
        {
            _damage = 7;
        }

        public Footman(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, mindamage, maxdamage, name, defence)
        {
        }



        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damage;
        }


        public void Rage()
        {
            if (Health <= 0)
            {
                Console.WriteLine("Defeated");
                return;
            }

            if (Health < MaxHealth / 2) 
            {
                _damage += _damage / 2; 
            }

            Console.WriteLine("Rage activated, damage increased to " + _damage);
        }
    }
}

