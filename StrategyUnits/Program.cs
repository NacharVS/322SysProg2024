using StrategyUnits;
Factory factory = new Factory();
Altar altar = new Altar();
Footman footman = factory.CreateFootman();
Bishop bishop = factory.CreateBishop();
footman.ShowInfo();
footman.InflictDamage(footman);
footman.InflictDamage(footman);
footman.InflictDamage(footman);
footman.ShowInfo();
bishop.Healinghealth(footman);
footman.ShowInfo();
bishop.ShowEnergy();

