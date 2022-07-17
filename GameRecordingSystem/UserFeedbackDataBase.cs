using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class UserFeedbackDataBase
    {
        public static List<UserFeedback> userFeedbackData;
        static UserFeedbackDataBase()
        {
            userFeedbackData = new List<UserFeedback>();
        }
        public void AddFeedback(string _feedback,string _email)
        {
            UserFeedback userFeedback = new UserFeedback();
            userFeedback.Feedback = _feedback;
            userFeedback.UserEmail = _email;
            userFeedbackData.Add(userFeedback);
        }
        public void ShowUserFeedback()
        {
            for (int i = 0; i < userFeedbackData.Count; i++)
            {
                Console.WriteLine("Kullanıcı :{0}\nGeri Bildirim:{1}", userFeedbackData[i].UserEmail,userFeedbackData[i].Feedback);
                Thread.Sleep(500);
            }
            Console.WriteLine("Enter tuşuna basarak devam edebilirsiniz.");
            Console.ReadLine();
        }
    }
}
