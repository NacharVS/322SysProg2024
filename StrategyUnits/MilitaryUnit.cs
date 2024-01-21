using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit
    {
        private int _damageMIN;
        private int _damageMAX;
        private Random random = new Random();
        public MilitaryUnit(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, defence)
        {
            _damageMIN = minDamage;
            _damageMAX = maxDamage;
        }
        public int AmountDamage()
        {
            return random.Next(_damageMIN , _damageMAX + 1);
        }

        public virtual void InflictedDamage(Unit unit)
        {
            if (Alive == true)
            {
                int damage = AmountDamage();
                unit.GetDamage(damage);
                Console.WriteLine($"{Name} нанес урон ({damage}) игроку : {unit.Name}");
            }
            else
            {
                Console.WriteLine("Юнит мертв, действие невозможно!");
            }
            
        }
        public delegate void InflictDamageDelegate(int damage, int health, string nameVictim, string nameCausedDamage);
        public event InflictDamageDelegate InflictDamageEvent;

    }
}
        //public int DamageMinimum
        //{
        //    get { return _damageMIN; }
        //    set { _damageMIN = value; }
        //}
        //public int DamageMaximum
        //{
        //    get { return _damageMAX; }
        //    set { _damageMAX = value; }
        //}
