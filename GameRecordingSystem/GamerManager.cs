using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class GamerManager : GamerDataBase
    {
        GameDatabase game = new GameDatabase();
        UserFeedbackDataBase userFeedbackData = new UserFeedbackDataBase();
        public void SignUp(Gamer gamer)
        {
            if (Control(gamer))
            {
                if (DataBaseControl(gamer))
                {
                    Add(gamer);
                    Console.WriteLine("Oyuncu sisteme başarıyla kaydedilmiştir.");
                    Thread.Sleep(2000);
                }
            }
            else
            {
                Console.WriteLine("Girdiğiniz değerlerde hata var lütfen kontrol edin");
            }
        }
        public void Update(string _email, string _password)
        {
            if (AccessControl(_email, _password))
            {
                DeleteRecord(DataBaseİndexOf(_email));
                ConsoleSimulation consoleSimulation = new ConsoleSimulation();
                consoleSimulation.NewRecordSimulation();
            }
            else
            {
                Console.WriteLine("Şifreniz veya email adresiniz hatalı!");
            }
        }
        public void Delete(string _email, string password)
        {
            if (AccessControl(_email, password))
            {
                DeleteRecord(DataBaseİndexOf(_email));
                Console.WriteLine("Silme işlemi başarıyla gerçekleşmiştir");
                Thread.Sleep(1000);
            }
            else
            {
                Console.WriteLine("Şifreniz veya email adresiniz hatalı!");
            }
        }
        public void GamerShowList()
        {
            Show();
        } 
        public void GameShowList()
        {
            game.ShowGameList();
        }
        public void UserFeedbackShowList()
        {
            userFeedbackData.ShowUserFeedback();
        }
        public void Buy(string _email,string _password)
        {
            if (AccessControl(_email,_password))
            {
                game.ShowGameList();
                Console.Write("Lütfen satın almak istediğiniz oyunu seçiniz :");
                int selectedgame = Convert.ToInt32(Console.ReadLine());
                ConsoleSimulation consoleSimulation = new ConsoleSimulation();
                consoleSimulation.GamerBuySimulation(selectedgame, game.GetGame(selectedgame - 1).Campaign);
            }
            else
            {
                Console.WriteLine("Böyle bir üye bulunmamaktadır. Eğer satın alım işlemi yapmak istiyorsanız önce üye olunuz");
                Thread.Sleep(2000);
            }
        }
        public void PaymentProcess(bool campaign,int selectedgame)
        {
            if (campaign)
            {
                Console.WriteLine("Seçtiğiniz oyunda kampanya bulunduğu için %50 indirim uygulanmıştır");
                Console.WriteLine("Oyunun indirimli fiyatı : {0}",game.GetGame(selectedgame - 1).GamePrice / 2);
                Thread.Sleep(3000);
            }
            // Kredi kartı bilgileri alınır ve ödeme yapılır...
            Console.WriteLine("Ödeme işlemi başarıyla gerçekleşmiştir.Bizi seçtiğiniz için teşekkür ederiz");
            Thread.Sleep(2000);
        }
        public void UserFeedback(string _email, string _password)
        {
            if (AccessControl(_email, _password))
            {
                Console.Write("Lütfen isteğinizi veya herhangi bir şikayetiniz varsa yazınız \n:");
                userFeedbackData.AddFeedback(Console.ReadLine(),_email);
                Console.WriteLine("Geri bildiriminiz için teşekkür ederiz. Gerekli yerlere iletilecektir.");
                Thread.Sleep(3000);
            }
            else
            {
                Console.WriteLine("Böyle bir kullanıcı bulunmamaktadır");
                Thread.Sleep(2000);
            }
        }
        private bool Control(Gamer gamer)
        {
            bool control = false;
            if (gamer.TcNo.Length == 11 && gamer != null && gamer.Email != null && gamer.Password != null)
            {
                control = true;
            }
            return control;
        }
        private bool AccessControl(string email,string password)
        {
            bool cnt = false;
            foreach (var item in gamers)
            {
                if (item.Email == email && item.Password == password)
                {
                    cnt = true;
                }
            }
            return cnt;
        }
    }
}
