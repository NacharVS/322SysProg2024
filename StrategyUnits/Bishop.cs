using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class Bishop : Unit, IMagicUnit, IHealthControl
    {
        private int _heal;
        Random random = new Random();
        public int Heal
        {
            get { return _heal; }
            set { _heal = value; }
        }  
        public Bishop( int health, int minDamage, int maxDamage, string name, int defence, int energy) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Defence = defence;
            Energy = energy;
        }
        public int Energy { get; set; }
        public int MaxEnergy { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Defence { get; set; }
        public int damaged { get; set; }
        




        public void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health}  Energy: {Energy} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence}");
        }
    }
}
