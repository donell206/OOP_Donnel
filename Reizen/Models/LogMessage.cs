using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reizen.Interfaces;

namespace Reizen.Models
{
    public class LogMessage
    {
        public static Random rnd = new Random();
        public int ID { get; private set; }
        public string Boodschap { get; private set; }

        public LogMessage(string boodschap)
        {



            ID = GenereerID();
            Boodschap = boodschap;
        }
        private int GenereerID()
        {
            return rnd.Next(1, 2000);
        }



    }
    
}

   
