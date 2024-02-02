using StrategyUnits.Interfaces;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Footman : Unit, IMilitaryUnit, IArmoredUnit, IFootRage
    {
        public int DamageMin { get; set ; }
        public int DamageMax { get; set; }

        public void Attack(IHealthControll unit)
        {
            unit.TakeDamage(AmountDamage());
        }
        private Random random = new Random();

        public Footman(int health, string? name, int defence, int minDamage, int maxDamage ) : base(health, name, defence)
        {
            DamageMin = minDamage;
            DamageMax = maxDamage;
            Defence = defence;
        }

        public int AmountDamage()
        {
            return random.Next(DamageMin, DamageMax + 1);
        }


        public void Rage() //Ярость
        {
            int damage = AmountDamage();
            if (Health < 0.5 * MaxHealth)
            {
                damage = (int)(1.5 * damage);
                Console.WriteLine($"{Name} в ярости! Урон увеличен на 50%!");
            }
            GetDamage( damage );
            Console.WriteLine($"{Name} нанес урон({damage}");
        }
    }
}
