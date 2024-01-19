using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MilitaryUnit : Unit// войны
    {
        private int _minDamage;
        private int _maxDamage;
        Random random = new Random();
        public MilitaryUnit(int health, string name , int minDamage ,int maxDamage , int defence) : base(health, name, defence)
        {
            _minDamage = minDamage;
            _maxDamage = maxDamage;
        }
        
        public int MinDamage { get { return _minDamage; } }
        public int MaxDamage { get { return _maxDamage; } }
        private int demage;
        public void InflictDamage(Unit unit , int percent)
        {
            if (unit.Alive != false)
            {
                demage = unit.Defence - (random.Next(_maxDamage - 1, _maxDamage) * percent / 100) ;
                Console.WriteLine($"Demage {demage} hp to {unit.Name}");
            }


        }
        public void InflictDamage(Unit unit )
        {
            if (unit.Alive != false)
            {
                demage = unit.Defence - random.Next(_maxDamage - 1, _maxDamage) ;
                Console.WriteLine($"Demage {demage} hp to {unit.Name}");
            }


        }
        public override void ShowInfo()
        {

            Console.WriteLine($"Unit: {Name} Health: {Health} Alive: {Alive} Min demage: {_minDamage} Max demage: {_maxDamage} Defence: {Defence} ");
        }
    }
}
