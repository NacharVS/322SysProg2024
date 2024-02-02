using StrategyUnits;

Barrac barrac = new Barrac();

Peasant peasant = new Peasant();
Footman footman = barrac.CreateFootman();
Berserker berserker = barrac.CreateBerserker();
Bishop bishop = barrac.CreateBishop();
Paladin paladin = barrac.CreatePalladin();
Zealot zealot = barrac.CreateZealot();

peasant.HealthDecreasedEvent += DropHealth;
peasant.HealthIncreasedEvent += AddHealth;
footman.HealthDecreasedEvent += DropHealth;
footman.HealthIncreasedEvent += AddHealth;
berserker.HealthDecreasedEvent += DropHealth;
berserker.HealthIncreasedEvent += AddHealth;
bishop.HealthDecreasedEvent += DropHealth;
bishop.HealthIncreasedEvent += AddHealth;
paladin.HealthDecreasedEvent += DropHealth;
paladin.HealthIncreasedEvent += AddHealth;
zealot.HealthDecreasedEvent += DropHealth;
zealot.HealthIncreasedEvent += AddHealth;

peasant.ShowInfo();
footman.ShowInfo();
berserker.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
zealot.ShowInfo();
Console.WriteLine();

footman.InflictDamage(paladin);
paladin.ShowInfo();
paladin.Prayer();
paladin.ShowInfo();

static void AddHealth(int MethHealth)
{
    Console.WriteLine($"Персонажа исцелили, текущее здоровье равно {MethHealth}");
}

static void DropHealth(int MethHealth)
{
    Console.WriteLine($"Персонаж получил урон, текущее здоровье равно {MethHealth}");
}