﻿using System;
using System.Collections.Generic;
using System.Diagnostics.SymbolStore;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyUnits
{
    internal class Zelot : Unit, IArmored, IMilitary, IMagic, IPrayer, IHaveSaintRow, IFaithArmored
    {
        public int Armor { get; set; }
        public int MinDamage { get; set; }
        public int MaxDamage { get; set; }
        public int Mana
        {
            get { return _mana; }
            set
            {
                if (value < 0)
                {
                    _mana = 0;
                }
                else
                {
                    if (value > MaxMana)
                    {
                        _mana = MaxMana;
                    }
                    else
                    {
                        _mana = value;
                    }
                }
            }
        }
        public int MaxMana { get; set; }
        public bool IsArmorOfFaith { get; set; }

        private int _mana;
        private Random random = new Random();

        public Zelot(int health, string? name, int minDamage, int maxDamage, int armor, int mana) : base(health, name)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            Armor = armor;
            MaxMana = mana;
            Mana = mana;
            HealthIncreasedEvent += CheckArmorOfFaith;
            HealthDecreasedEvent += CheckArmorOfFaith;
        }

        public void CheckArmorOfFaith(double health)
        {
            if (health <= MaxHealth * 0.3 && !IsArmorOfFaith)
            {
                IsArmorOfFaith = true;
                Armor += Armor;
            }
            else if(health > MaxHealth * 0.3 && IsArmorOfFaith)
            {
                IsArmorOfFaith = false;
                Armor -= Armor / 2;
            }
        }

        public void Attack(IHealthController unit)
        {
            unit.TakeDamage(CountDamage());
        }

        public double CountDamage()
        {
            return random.Next(MinDamage, MaxDamage);
        }

        public override void TakeDamage(double damage)
        {
            if (damage - Armor > 0)
            {
                base.TakeDamage(damage - Armor);
            }
        }

        public void Prayer()
        {
            if (Mana >= 10)
            {
                Mana -= 10;
                TakeHeal(20);
            }
            else
            {
                Console.WriteLine($"У {Name} недостаточно маны для заклинания Prayer");
            }
        }

        public void SaintRow(IHealthController unit)
        {
            if (Mana >= 3)
            {
                unit.TakeDamage(CountDamage() * 2);
                Mana -= 3;
            }
        }
    }
}
