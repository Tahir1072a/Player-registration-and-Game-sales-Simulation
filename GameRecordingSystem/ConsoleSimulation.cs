using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class ConsoleSimulation
    {
        GamerManager gManager = new GamerManager();
        public void Menu()
        {
            bool dng = true;
            while (dng)
            {
                Console.Clear();
                Console.WriteLine("1 - Yeni Oyuncu Kayıt");
                Console.WriteLine("2 - Kayıt Güncelleme");
                Console.WriteLine("3 - Kayıt Silme");
                Console.WriteLine("4 - Kayıtları Listele");
                Console.WriteLine("5 - Oyunları Listeleme");
                Console.WriteLine("6 - Oyun satın alma");
                Console.WriteLine("7 - Oyunu geri iade etme");
                Console.WriteLine("8 - İstek ve Şikayet");
                Console.WriteLine("9 - İstek ve Şikayetleri Listele");
                Console.WriteLine("10- Çıkış");
                Console.Write("Lütfen yapmak istediğiniz işlemi seçiniz :");
                switch (Console.ReadLine())
                {
                    case "1":
                        NewRecordSimulation();
                        break;
                    case "2":
                        RecordUpdateSimulation();
                        break;
                    case "3":
                        RecordDeleteSimulation();
                        break;
                    case "4":
                        gManager.GamerShowList();
                        break;
                    case "5":
                        GameShowSimulation();
                        break;
                    case "6":
                        GameBuySimulation();
                        break;
                    case "7":
                        Console.WriteLine("Şu anda sistemsel bir hatadan dolayı bu işlemi gerçekleştiremiyoruz.");
                        Thread.Sleep(3000);
                        break;
                    case "8":
                        RequestandComplaintSimulation();
                        break;
                    case "9":
                        UserFeedbackShowSimulation();
                        break;
                    case "10":
                        dng = false;
                        break;
                    default:
                        break;
                }
            }
        }
        public void NewRecordSimulation()
        {
            Gamer g = new Gamer();
            //GamerManager gManager = new GamerManager();
            Console.WriteLine("Lütfen aşağıdaki bilgileri eksiksiz biçimde doldurunuz");
            Console.Write("GamerId :");
            g.GamerID = Convert.ToInt32(Console.ReadLine());
            Console.Write("Gamer Name :");
            g.GamerName = Console.ReadLine();
            Console.Write("Gamer SurName :");
            g.GamerSurname = Console.ReadLine();
            Console.Write("Gamer TcNo :");
            g.TcNo = Console.ReadLine();
            Console.Write("Gamer Email :");
            g.Email = Console.ReadLine();
            Console.Write("Gamer Password :");
            g.Password = Console.ReadLine();
            Console.Write("Not : Lütfen 05.03.2003 tipinde yazınız..\nGamer BirtDay :");
            g.Birthday = Convert.ToDateTime(Console.ReadLine());
            gManager.SignUp(g);
        }
        public void GamerBuySimulation(int x,bool y)
        {
            switch (x)
            {
                case 1:
                    gManager.PaymentProcess(y,x);
                    break;
                case 2:
                    gManager.PaymentProcess(y,x);
                    break;
                default:
                    break;
            }
        }
        private void RecordUpdateSimulation()
        {
            Console.Write("Lütfen email adresinizi giriniz :");
            string email = Console.ReadLine();
            Console.Write("Lütfen şifrenizi giriniz :");
            string password = Console.ReadLine();
            gManager.Update(email, password);
        }
        private void RecordDeleteSimulation()
        {
            Console.Write("Lütfen email adresinizi giriniz :");
            string email = Console.ReadLine();
            Console.Write("Lütfen şifrenizi giriniz :");
            string password = Console.ReadLine();
            gManager.Delete(email, password);
        }
        private void GameBuySimulation()
        {
            Console.Write("Lütfen email adresinizi giriniz :");
            string email = Console.ReadLine();
            Console.Write("Lütfen şifrenizi giriniz :");
            string password = Console.ReadLine();
            gManager.Buy(email, password);
        }
        private void GameShowSimulation()
        {
            gManager.GameShowList();
        }
        private void UserFeedbackShowSimulation()
        {
            gManager.UserFeedbackShowList();    
        }
        private void RequestandComplaintSimulation()
        {
            Console.Write("Lütfen email adresinizi giriniz :");
            string email = Console.ReadLine();
            Console.Write("Lütfen şifrenizi giriniz :");
            string password = Console.ReadLine();
            gManager.UserFeedback(email, password);
        }
    }
}
