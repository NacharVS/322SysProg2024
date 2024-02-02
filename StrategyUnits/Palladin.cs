using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Palladin : Unit, IMagicUnit , IPrayer, IMagicDamage, IHealthControl
    {
        Random random = new Random();
         

        public Palladin(int health, string name, int minDamage, int maxDamage, int defence, int energy) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Defence = defence;
            Energy = energy;
            prayerBool = true;
        }

        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defence { get; set; }
        public int damaged { get; set; }
        public bool prayerBool { get; set; }

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
            TakeDamage(unit, RandomDamage() * procent / 100);
        }


        public void MagicDemage( Unit unit)
        {
            if(120 > Energy)
            {
                Console.WriteLine("No Mana");
            }
            else
            {
                unit.Health -= 40;
                Energy -= 120;
                Console.WriteLine($"Demage 40 hp to {unit.Name}");
            } 
        }
        public void Prayer()
        {

                if (Health != MaxHealth || prayerBool == false )//yugsfyiugsiydfgiusgf
                {
                    prayerBool = false;
                    while (Health < MaxHealth && Energy > 0)
                    {
                        Health+=20;
                        Energy -= 10;
                    }
                }
        }
        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Energy: {Energy} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence}");
        }

    }
}