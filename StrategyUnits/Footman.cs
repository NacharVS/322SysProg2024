namespace StrategyUnits
{
    internal class Footman : Unit, IHealthController, IArmoredUnit, IBattleUnit, IRage 
    {
        Random random = new Random();
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public int Armor { get; set; }


        public bool IsRage { get; set; }

        public int Damage
        {
            get { return Armor; }
            set { Armor = value; }
        }

        public int MaxHealth { get ; set ; }

        private bool Rage()
        {
            return Health <= MaxHealth * 0.5;
        }
        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name)
        {

        }


        public void TakeDamage(int damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                Health -= Damage;
            }
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage((int)CountDamage());
        }
        public  double CountDamage()
        {
            if (!IsRage)
                return random.Next(DamageMin, DamageMax);
            else
                return random.Next(DamageMin, DamageMax);
        }


        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }

        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
    }
}


