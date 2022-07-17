using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class GamerDataBase 
    {
        public static List<Gamer> gamers;
        static GamerDataBase()
        {
            gamers = new List<Gamer>();
        }
        public void Add(Gamer gamer)
        {
            gamers.Add(gamer);
        }
        public void Show()
        {
            foreach (var bigitem in gamers)
            {
                Console.WriteLine(bigitem.GamerID + " -" + bigitem.GamerName + " " + bigitem.GamerSurname);
            }
            Thread.Sleep(3000);
        }
        public void DeleteRecord(int _i)
        {
            gamers.RemoveAt(_i);
        }
        public bool DataBaseControl(Gamer gamer)
        {
            bool cnt = true;
            for (int i = 0; i < gamers.Count; i++)
            {
                if (gamers[i].Email == gamer.Email)
                {
                    Console.Clear();
                    Console.WriteLine("Bu email adresi sisteme kayıtlı. Lütfen başka bir e posta adresi giriniz");
                    cnt = false;
                }
            }
            return cnt;
        }
        public int DataBaseİndexOf(string _email)
        {
            int a = 0;
            for (int i = 0; i < gamers.Count; i++)
            {
                if (gamers[i].Email == _email)
                {
                    a = i;
                    break;
                }
            }
            return a;
        }
    }
}
