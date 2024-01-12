using StrategyUnits;

Footman footman = new Footman();
Footman footman2 = new Footman();
Peasant ps1 = new Peasant();
Bishop bishop1 = new Bishop();
MagicFountain magicFountain1 = new MagicFountain();

ps1.ShowInfo();
footman2.ShowInfo();
footman.InflictDamage(ps1);
footman.InflictDamage(footman2);
footman.InflictDamage(footman2);
ps1.ShowInfo();
footman2.ShowInfo();
bishop1.ShowInfo();
bishop1.Heal(footman2);
footman2.ShowInfo();
bishop1.ShowInfo();
magicFountain1.RestoreEnergy(bishop1);
bishop1.ShowInfo();