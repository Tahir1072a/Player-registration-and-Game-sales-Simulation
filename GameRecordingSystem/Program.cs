using GameRecordingSystem;
GamerDataBase gamerDataBase = new GamerDataBase();  
GameDatabase gamedatabase = new GameDatabase();

#region Oyun veritabanı // Daha sql kullanmadığım için böyle yapmak zorundayım
Game game1 = new Game();
game1.GameID = 1;
game1.GameName = "Volarant";
game1.GamePrice = 70;

Game game2 = new Game();
game2.GameID = 2;
game2.GameName = "Age of Empires 4";
game2.GamePrice = 130;
game2.Campaign = true;

GameDatabase.games.Add(game1);
GameDatabase.games.Add(game2);
#endregion

ConsoleSimulation simulation = new ConsoleSimulation();
simulation.Menu();

