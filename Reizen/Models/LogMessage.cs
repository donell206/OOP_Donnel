using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reizen.Interfaces;

namespace Reizen.Models
{

    #region faux 
    public class LogMessage
    {
        public static Random rnd = new Random();
        

        public int ID { get;  set; }
        public string Boodschap { get; set; }

        public LogMessage(string boodschap)
        {

            ID = GenereerID();
            Boodschap = boodschap;
        }

        

        public int GenereerID()
        {
          

            return rnd.Next(1, 20);
        }



    }
}
#endregion end faux



//    public class LogMessage
//{
//    
//    public int ID { get; set; }
//    public string Boodschap { get; set; }
//    public LogMessage(string boodschap)
//    {
//        Boodschap = boodschap;
//        ID = GenereerID();
//    }
//    public int GenereerID()
//    {
//        return LoggerService.Logs.Length;
//    }
//  }
//}