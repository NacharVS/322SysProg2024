using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits.Useless
{
    internal class MagicUnit : MilitaryUnit
    {
        //private int _healPoints;
        //private int _energyPoints;
        //private int _energyLimit;
        private int _energy;
        private int _maxEnergy;

        public MagicUnit(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
            _energy = 10;
            _maxEnergy = 100;
        }

        public int Energy
        {
            get { return _energy; }
            set { _energy = value; }
        }
        public int MaxEnergy
        {
            get { return _maxEnergy; }
        }


        public override void ShowInfo()
        {
            Console.WriteLine($"Герой : {Name} имеет {Health} единиц здоровья. " +
                $"У него осталось {Energy} единиц маны и из защиты есть {Defence} единиц. ");
        }
    }
}
//public int energyLimit
//{
//    get { return _energyLimit;}
//    set { _energyLimit = value; }
//}
//public int EnergyPoints
//{
//    get { return _energyPoints; }
//    set { _energyPoints = value; }
//}
//public int HealPoints
//{
//    get { return _healPoints; }
//    set { _healPoints = value; }
//}