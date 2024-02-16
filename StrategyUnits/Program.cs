using StrategyUnits;

Barracs barracs = new Barracs();    
Footman footman = barracs.CreateFootman();
Footman footman2 = barracs.CreateRecruit();
Peasant ps1 = new Peasant();
Bishop bishop1 = barracs.CreateBishop();
Paladin pl = barracs.CreateAncient();
Berserk berserk = barracs.CreateLegendary();
Zelot zel = barracs.CreateEpic();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
bishop1.GetHealth(footman2);
bishop1.GetHealth(ps1);
footman.ShowInfo();
ps1.ShowInfo();
bishop1.ShowInfo();
berserk.Frenzy();
pl.Prayer();
pl.SaintHeal();
zel.CheckArmorOfFaith();
