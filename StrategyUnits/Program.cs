using StrategyUnits;

void DecreaseHP(int hp)
{
    Console.WriteLine($"lost {hp} hp");
}

void IncreaseHP(int hp)
{
    Console.WriteLine($" take {hp} hp");
}



barrack barrack = new barrack();
Footman footman = barrack.GetFootman();
Footman footman2 = barrack.CreateOfficer();
Palladin pl = barrack.CreateDwarf();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Bishop bishop = new Bishop();
Altar altar = new Altar();
altar.Info();
pl.ShowInfo();
ps1.ShowInfo();
ps2.ShowInfo();
bishop.ShowInfo();
footman.ShowInfo();
footman2.ShowInfo();

footman.HealthDecreasedEvent += DecreaseHP;
footman2.HealthDecreasedEvent += DecreaseHP;
pl.HealthDecreasedEvent += DecreaseHP;
footman.HealthIncreasedEvent += IncreaseHP;
footman2.HealthIncreasedEvent += IncreaseHP;
pl.HealthIncreasedEvent += IncreaseHP;


pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

pl.MagicDemage(footman2);

footman.InflictDamage(pl);
pl.Prayer();
footman2.InflictDamage(ps1);

