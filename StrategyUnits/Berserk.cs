using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Berserk : Unit, IFrenzy ,IInflictDamage, IDefence, IRandomDamgeController, IMilitaryUnit,IHealthControl
    {
        Random random = new Random();
        public Berserk(int health, int mindamage, int maxdamage, string? name, int defence) : base(health, name)
        {
            MinDamage = mindamage;
            MaxDamage = maxdamage;
            Defence = defence;
            berserkmode = true;
        }
        private bool berserkmode;
        public void Frenzy()
        {
            if (Health < 0.3 * MaxHealth)
            {
                berserkmode = true;
                Console.WriteLine("Berserk is franzy");
            }
        }
        public int Defence { get; set; }
        public int damaged { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        bool IFrenzy.berserkmode { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public int RandomDamage(int MinDamage, int MaxDamage)
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage(MinDamage, MaxDamage));
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }
    }
}
