using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Peasant ps2 = new Peasant();
Bishop bishop = new Bishop();
ps1.ShowInfo();
ps2.ShowInfo();
footman2.ShowInfo();
bishop.ShowInfo();
Console.WriteLine();

footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);

bishop.Helping(ps1);
bishop.InfoEnergy();

footman.InflictDamage(bishop);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);
footman.InflictDamage(ps2);

bishop.Helping(ps2);
bishop.InfoEnergy();

bishop.Helping(bishop);

ps1.ShowInfo();
ps2.ShowInfo();
footman2.ShowInfo();
bishop.ShowInfo();