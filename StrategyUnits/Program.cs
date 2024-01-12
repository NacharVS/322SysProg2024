using StrategyUnits;

Footman footman = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();

ps1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
bishop1.HealUnit(ps1);
ps1.ShowInfo();
bishop1.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
footman.InflictDamage(ps1);
ps1.ShowInfo();
bishop1.HealUnit(ps1);
ps1.ShowInfo();
bishop1.ShowInfo();