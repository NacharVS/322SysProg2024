using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserker : Unit , IFrenzy, IInflictDamage, IDefence , IRandomDamgeController, IMilitaryUnit
    {
        Random random = new Random();
        public Berserker(int health, string name, int minDamage, int maxDamage, int defence) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Defence = defence;
        }

        public int Defence { get; set ; }
        public int damaged { get; set ; }
        public int MinDamage { get ; set; }
        public int MaxDamage { get ; set; }

        public void Frenzy(Unit unit)
        {
            if( Health < MaxHealth * 0.3)
            {
            InflictDamage(unit, 500);
            }
            else{
                System.Console.WriteLine("Cannot be Frenzy");
            }
        }

        public int RandomDamage()
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage());
        }
        public void InflictDamage(Unit unit,  int procent)
        {
            TakeDamage(unit, RandomDamage() * procent / 100);
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }
    }
}
