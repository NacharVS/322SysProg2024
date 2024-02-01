﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StrategyUnits
{
    internal class MagicUnit : Unit
    { 
        private int _mana;
        public int MaxDamage { get;set; }
        public int MinDamage { get; set; }
        public MagicUnit(int health, string? name, int _damangemax, int _damangemin, int mana, int defense) : base(health, name)
        {
            MaxMana = mana;
            _mana = mana;
        }
        public int MaxMana
        {
            get;
            private set;
        }

        public int mana
        {

            get
            {
                return _mana;
            }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                        _mana = MaxMana;
                    else
                        _mana = value;
                }
            }
        }
        public int RemovedMana { get => MaxMana - mana; }
        public  void ShowInfo()
        {
            Console.WriteLine($"Unit: {Name} Health: {Health} MaxHealth: {maxHealth} Energy:{mana} MaxEnergy:{MaxMana} DamangeMax:{MaxDamage} DamangeMin:{MinDamage} Defence:{Defence} ");
        }
    }
}

