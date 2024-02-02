using StrategyUnits;

void DecreaseHP(int hp)
{
    Console.WriteLine($"lost {hp} hp");
}

void IncreaseHP(int hp)
{
    Console.WriteLine($"take {hp} hp");
}



barrack barrack = new barrack();
Footman footman = barrack.GetFootman();
Footman footman2 = barrack.CreateOfficer();
Palladin pl = barrack.CreateDwarf();



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



System.Console.WriteLine("1");
Berserker berserker = barrack.GetJKalinudini();
Berserker berserker1 = barrack.GetDrykinRahimi();
berserker.ShowInfo();
berserker1.ShowInfo();

berserker.InflictDamage(pl);


