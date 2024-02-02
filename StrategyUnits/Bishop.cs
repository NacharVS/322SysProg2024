using System;

namespace StrategyUnits
{
    internal class Bishop :Unit , IMagicUnit , IHealthControl
    {
        Random random = new Random();
        public Bishop(string name , int health, int minDamage , int maxDamage,int defence, int energy) : base(health, name)//медик
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Defence = defence;
            Energy = energy;

        }

        public int Energy { get ; set ; }
        public int MaxEnergy { get ; set ; }
        public int MinDamage { get ; set ; }
        public int MaxDamage { get ; set ; }
        public int Defence { get ; set ; }
        public int damaged { get ; set ; }

        public void GetHealth(Unit unit, int _health)
        {
            if (Energy != 0)
            {
                if (unit.Health != unit.MaxHealth)
                {
                    while (unit.Health < unit.MaxHealth && Energy > 0)
                    {
                        unit.Health++;
                        Energy -= 2;
                    }
                }
                else { Console.WriteLine("Unit Max HP"); }
            }
            else { Console.WriteLine("Cannot be hill"); }

        }

        public int RandomDamage()
        {
            return random.Next(MinDamage - 1, MaxDamage);
        }
        public void InflictDamage(Unit unit)
        {
            TakeDamage(unit, RandomDamage());
        }
        public void InflictDamage(Unit unit, int procent)
        {
            TakeDamage(unit, (RandomDamage() * procent / 100));
        }


        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Energy: {Energy} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence}");
        }
    }
}
