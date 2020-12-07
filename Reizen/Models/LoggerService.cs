using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{

    public static class LoggerService
    {
        private static LogMessage[] logs;
 

        public static LogMessage[] Logs
        {
            get
            {
                return logs;
            }
            set { logs = value; }
        }

        static LoggerService()
        {
            logs = new LogMessage[0];
        }

        public static void AddLogMessage(LogMessage message)
        {
            int Sizere = logs.Length + 1;


            Array.Resize(ref logs, Sizere);
            //Array.Resize(ref logs, logs.Length + 1);
            logs[logs.Length - 1] = message;
        }
    }

}