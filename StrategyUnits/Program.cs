using StrategyUnits;

MagicFountain fountain= new MagicFountain();
Barracks barracks = new Barracks();
Hut hut = new Hut();
Footman footman = barracks.CreateFootman();
Peasant ps1 = hut.CreatePeasant();
Bishop bishop1 = fountain.CreateBishop();

footman.ShowInfo();
footman.InflictDamage(footman);
bishop1.HealUnit(footman);

