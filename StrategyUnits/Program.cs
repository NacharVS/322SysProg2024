using StrategyUnits;

Barracs barracs = new Barracs();    
Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
Paladin pl = new Paladin();
Berserk berserk = barracs.CreateLegendary();
Zelot zel = barracs.CreateEpic();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
bishop1.InflictHeal(footman2);
bishop1.InflictHeal(ps1);
footman.ShowInfo();
ps1.ShowInfo();
bishop1.ShowInfo();
berserk.Frenzy();
pl.Prayer();
pl.SaintHeal();
zel.CheckArmorOfFaith();
