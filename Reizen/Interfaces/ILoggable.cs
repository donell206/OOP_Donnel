using Reizen.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Interfaces
{
    interface ILoggable
    {
        public LogMessage LogMessage { get;}
    }
}
