using StrategyUnits;

Footman footman = new Footman(60, "Footman", 5, 14, 19);
Footman footman2 = new Footman(60, "Footman", 5, 14, 19);
Peasant ps1 = new Peasant();
Bishop bishop = new Bishop();
Church church = new Church();
Paladin paladin = new Paladin(40, "Paladin", 7, 9, 13, 40);

ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();
ps1.HealthDecreasedEvent += DropHealth;
ps1.HealthIncreasedEvent += AddHealth;
footman2.HealthDecreasedEvent += DropHealth;
footman2.HealthIncreasedEvent += AddHealth;
footman.HealthDecreasedEvent += DropHealth;
footman.HealthIncreasedEvent += AddHealth;
bishop.HealthDecreasedEvent += DropHealth;
bishop.HealthIncreasedEvent += AddHealth;
paladin.HealthDecreasedEvent += DropHealth;
paladin.HealthIncreasedEvent += AddHealth;

footman.InflictDamage(ps1);
footman2.InflictDamage(paladin);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman2.Rage(footman);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

bishop.InFlickHill(ps1);
bishop.InFlickHill(footman2);
bishop.InFlickHill(paladin);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

footman2.InflictDamage(ps1);
paladin.SacredBlow(footman);
paladin.InflictDamage(bishop);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

church.EnergyRegen(bishop);
church.EnergyRegen(paladin);
ps1.ShowInfo();
footman2.ShowInfo();
footman.ShowInfo();
bishop.ShowInfo();
paladin.ShowInfo();
church.ShowInfo();
Console.WriteLine();

static void AddHealth(int MethHealth)
{
    Console.WriteLine($"Персонажа исцелили, текущее здоровье равно {MethHealth}");
}

static void DropHealth(int MethHealth)
{
    Console.WriteLine($"Персонаж получил урон, текущее здоровье равно {MethHealth}");
}