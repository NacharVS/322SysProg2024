using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Footman footman2 = new Footman();
ps1.ShowInfo();
footman.InflictDamage(ps1);

footman.InflictDamage(footman2);


footman2.ShowInfo();
