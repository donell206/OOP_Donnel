using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public static class LoggerService
    {


        //public static LogMessage[] logs;



        public static LogMessage[] logs = new LogMessage[0];

        //public static LogMessage[] Logs 
        //{
        //    get { return _logs; } 
        //    set { _logs = value; } 
        //}

       


        public static void AddLogMessage(LogMessage message)
        {​​​​
            int i =+logs.Length;
            Array.Resize(ref logs,i);
            logs[logs.Length - 1] = message;
        }

    }
 }

