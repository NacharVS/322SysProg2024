using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Altar altar1 = new Altar();

ps1.ShowInfo();
footman.InflictDamage(ps1);
ps1.ShowInfo();
bishop1.InflictHeal(ps1,bishop1);
ps1.ShowInfo();
bishop1.ShowInfo();
altar1.GetIncreased(bishop1);
bishop1.ShowInfo();
