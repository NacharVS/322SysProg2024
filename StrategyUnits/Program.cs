using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();

Bishop bishop = new Bishop();
bishop.ShowInfo();
bishop.Heal(footman);
footman.ShowInfo();