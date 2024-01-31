using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace StrategyUnits
{
    internal class Zelot: Unit, IMagicUnit, IArmoredUnit, IHealthController, IBattleUnit, ICheckArmorOfFaithSkill
    {
        public Zelot(int health, string? name, int minDamage, int maxDamage, int defence, int energy) : base(health, name)
        {
            HealthIncreasedEvent += CheckArmorOfFaith;
            HealthDecreasedEvent += CheckArmorOfFaith;
        }

        public int HealPoints { get; set; }
        public int EnergyPoints { get; set; }
        public int EnergyLimit { get; set; }
        public int Armor { get; set; }
        public int attack { get; set; }
        public int DamageMin { get; set; }
        public int DamageMax { get; set; }
        Random random = new Random();
        public void Attack(IHealthController unit)
        {
            throw new NotImplementedException();
        }
        public void Refill(int EnergyAmount)
        {
            EnergyPoints += EnergyAmount;
        }
        public void TakeDamage(int damage)
        {
            if (Armor > Damage)
            {
                Armor -= (int)Damage;
            }
            else
            {
                Damage -= Armor;
                Armor = 0;
                health -= Damage;
            }
        }
    }

        public void TakeHeal(int healAmount)
        {
            throw new NotImplementedException();
        }
    public double CountDamage()
    {
        return random.Next(DamageMin, DamageMax);
    }

    public void InflictDamage(IHealthControl unit)
    {
        unit.TakeDamage(CountDamage());
    }

    private void CheckArmorOfFaith(double health)
        {
            if (health <= MaxHealth * 0.3)
            {

                Defence += Defence;
            }
            else if (health > MaxHealth * 0.3)
            {

                Defence -= Defence / 2;
            }

        }

    }

