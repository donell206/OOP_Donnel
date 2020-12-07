using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public class Cruise:Reis
    {
        public const int CRUISEPRIJSEXTRADAGCOST = 10;

        private bool VIP { get; set; }


        public Cruise(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, bool vip) : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
            VIP = vip;
        }

        public override double BerekenPrijs()
        {
            if (VIP == true)
            {
                return base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGCOST * AantalPersonen) * 1.5;
            }
            else
            {
                return base.BerekenPrijs() + (CRUISEPRIJSEXTRADAGCOST * AantalPersonen);

            }
        }
    }
}
