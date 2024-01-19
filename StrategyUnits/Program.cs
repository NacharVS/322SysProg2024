using StrategyUnits;

MagicFountain fountain= new MagicFountain();
Barracks barracks = new Barracks();
Hut hut = new Hut();
Zealot zealot = fountain.CreateZealot();
Paladin paladin = fountain.CreatePaladin();
Berserker berserker = barracks.CreateBerserker();

zealot.ShowInfo();
paladin.ShowInfo();
paladin.SaintTouch(zealot);
paladin.SaintTouch(zealot);
paladin.SaintTouch(zealot);
paladin.SaintTouch(zealot);
paladin.SaintTouch(zealot);
zealot.ShowInfo();
zealot.Prayer();
zealot.ShowInfo();
berserker.ShowInfo();
paladin.InflictDamage(berserker);
paladin.InflictDamage(berserker);
paladin.InflictDamage(berserker);
berserker.ShowInfo();