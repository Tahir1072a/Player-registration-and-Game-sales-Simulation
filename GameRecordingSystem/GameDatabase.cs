using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class GameDatabase 
    {
        public static List<Game> games;
        static GameDatabase()
        {
            games = new List<Game>();
        }
        public void ShowGameList()
        {
            for (int i = 0; i < games.Count; i++)
            {
                if (games[i].Campaign)
                {
                    Console.WriteLine("{0} -{1}\n Ücreti :{2}", i + 1, games[i].GameName, games[i].GamePrice);
                    Console.WriteLine("KAMPANYA! Eğer {0} isimli oyunu alırsanız ödeme bölümünde %50 indirim uygulnacaktır", games[i].GameName);
                    Thread.Sleep(1000);
                }
                else
                {
                    Console.WriteLine("{0} -{1}\n Ücreti :{2}", i + 1, games[i].GameName, games[i].GamePrice);
                    Thread.Sleep(1000);
                }
            }
            Thread.Sleep(1000); 
        }
        public Game GetGame(int i)
        {
            return games[i];
        }
    }
}
