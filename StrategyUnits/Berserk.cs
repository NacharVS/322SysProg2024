using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyUnits.Interfaces;

namespace StrategyUnits
{
    internal class Berserk : Unit, IMilitaryUnit, IArmoredUnit, IFrenzy
    {
        public Berserk(int health, string? name, int defence, int minDamage, int maxDamage) : base(health, name, defence)
        {
            DamageMin = minDamage;
            DamageMax = maxDamage;
            Defence = defence;
        }

        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        public bool IsFrenzy { get; set; }

        public void Attack(IHealthControll unit)
        {
            throw new NotImplementedException();
        }
       
      private Random random = new Random();
        public int AmountDamage()
        {
            return random.Next(DamageMin, DamageMax + 1);
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
        
        public void Frenzy()
        {
            int damage = AmountDamage();
            if (Health <= MaxHealth * 0.3)
            {
                damage *=3;
            }
        }

        public override void GetHeal(int CountHeal)
        {
            if (!(Health <= MaxHealth * 0.3))
            {
                base.GetHeal(CountHeal);
            }
        }

        
    }
}
