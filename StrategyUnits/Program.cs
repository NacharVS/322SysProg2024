using StrategyUnits;

Barrack barrack = new Barrack();
Cottage cottage = new Cottage();
MagicFountain magicFountain1 = new MagicFountain();
Footman footman = barrack.CreateFootman();
Footman footman2 = barrack.CreateFootmanOfficer();
Peasant ps1 = cottage.CreatePeasant();
Bishop bishop1 = magicFountain1.CreateBishop();
Berserker berserker = barrack.CreateBerserker();

ps1.ShowInfo();
berserker.ShowInfo();
berserker.InflictDamage(ps1);
ps1.ShowInfo();
footman2.InflictDamage(berserker);
footman2.InflictDamage(berserker);
footman2.InflictDamage(berserker);
footman2.InflictDamage(berserker);
footman2.InflictDamage(berserker);
berserker.InflictDamage(ps1);
ps1.ShowInfo();