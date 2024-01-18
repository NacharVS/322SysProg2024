using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Footman : MilitaryUnit
    {
        private int _Damage;

        public Footman() : base(60, "Footman")
        {
            DamageMinimum = 1;
            DamageMaximum = 8;
            Random random = new Random();
            _Damage = random.Next(DamageMinimum, DamageMaximum);
            Defence = 6;
            
        }

        public override void ShowInfo()
        {
            Console.WriteLine($"{Name} damage: {_Damage}. {Health}/{MaxHealth}");
        }

    }
}
