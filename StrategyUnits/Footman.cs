using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        //private int _Damage;

        public Footman(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name,  minDamage,  maxDamage, defence)
        {
        }
        public void Rage(Unit unit) //Ярость
        {
            int damage = AmountDamage();
            if (Health < 0.5 * MaxHealth)
            {
                damage = (int)(1.5 * damage);
                Console.WriteLine($"{Name} в ярости! Урон увеличен на 50%!");
            }
            unit.GetDamage(damage);
            Console.WriteLine($"{Name} нанес урон( {damage}) игроку: {unit.Name}" );
        }
    }
}
