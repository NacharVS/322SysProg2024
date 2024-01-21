using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit
    {
        //private int _healPoints;
        //private int _energyPoints;
        //private int _energyLimit;
        private int _manas;
        private int _maxMana;

        public MagicUnit(int health, string? name, int minDamage, int maxDamage, int defence) : base(health, name, minDamage, maxDamage, defence)
        {
            _manas = 10;
            _maxMana = 100;
        }

        public int Mana
        {
            get { return _manas; }
            set { _manas = value; }
        }
    public int MaxMana
        {
            get { return _maxMana; }
        }

       
    public override void ShowInfo()
    {
        Console.WriteLine($"Герой : {Name} имеет {Health} единиц здоровья. " +
            $"У него осталось {Mana} единиц маны и из защиты есть {Defence} единиц. ");
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