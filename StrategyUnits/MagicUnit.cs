using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : MilitaryUnit// магия
    {
        private int _energy;
        private int _maxEnergy;
        public MagicUnit(int health, string name, int minDamage, int maxDamage, int defence, int energy) : base(health, name, minDamage, maxDamage, defence)
        {
            _energy = energy;
            _maxEnergy = _energy;
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

            Console.WriteLine($"Unit: {Name} Health: {Health} Alive: {Alive} Energy: {_energy} Min demage: {MinDamage} Max demage: {MaxDamage} Defence: {Defence} ");
        }
    }

}
