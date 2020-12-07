using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Reizen.Interfaces;

namespace Reizen.Models
{
    public class ReisReservatie:ILoggable
    {
        public Persoon Persoon { get; set; }
        public Reis Reis { get; set; }
        public Reisbureau Reisbureau { get; set; }

        public LogMessage LogMessage
        {
           get
            {
                return new LogMessage($"U heeft een vervoerbewijs genomen MET : {Persoon.Naam} via het reisbureau {Reisbureau.Naam}");
            }
        }





        public ReisReservatie(Persoon persoon, Reis reis, Reisbureau reisbureau)
        {
            Persoon = persoon;
            Reis = reis;
            Reisbureau = reisbureau;
            LoggerService.AddLogMessage(LogMessage);
        }

        public ReisReservatie(Reis reis, Reisbureau reisbureau, Persoon persoon)
        {
            Reis = reis;
            Reisbureau = reisbureau;
            Persoon = persoon;
            LoggerService.AddLogMessage(LogMessage);

        }
    }
}
