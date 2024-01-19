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

        public Footman() : base(60, "Footman", 12, 9, 50)
        {
            _damageFootman = 7;
        }

        public void InflictDamage(Unit unit)
        {
            unit.Health -= _damageFootman;
        }



        public void PageFootman(MilitaryUnit militaryUnit)
        {
            if(militaryUnit.Health < militaryUnit.Max_healt/2)
            {
                double _damage = militaryUnit.RandomDamage() * 1.5;

            }
        }
    }
}
