using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameRecordingSystem
{
    public class Gamer
    {
        public int GamerID { get; set; }
        public string GamerName { get; set; }
        public string GamerSurname { get; set; }
        public string TcNo { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public DateTime Birthday { get; set; }
    }
}
