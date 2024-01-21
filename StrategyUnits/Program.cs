using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop(); 
Paladin pal = new Paladin();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
bishop1.InflictHeal(ps1);
ps1.ShowInfo();
bishop1.ShowInfo();
pal.ShowInfo();