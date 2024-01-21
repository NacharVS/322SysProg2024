using System.Text;

namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _damageFootman;

        public int Damage
        {
            get { return _damageFootman; }
            set { _damageFootman = value; }
        }

        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(60, "Footman", 12, 9, 50)
        {
      
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damageFootman;
        }



        public void PageFootman(Unit unit)
        {
            if(unit.Health < unit.Max_healt/2)
            {
                unit.TakeDamage((int)(RandomDamage() * 1.5));

            }
        }
    }
}
