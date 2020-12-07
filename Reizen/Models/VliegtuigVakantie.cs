using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public class VliegtuigVakantie:Reis
    {


        private double vliegtuigTicketPrijs;

        public double VliegtuigTicketPrijs
        {get; private set;}

        public VliegtuigVakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, double vliegtuigTicketPrijs) : base(vertrekDatum, terugkeerDatum,aantalPersonen)
        {
            VliegtuigTicketPrijs = vliegtuigTicketPrijs;
        }

        public override double BerekenPrijs()
        {

            return base.BerekenPrijs() + VliegtuigTicketPrijs;
        }
    }
}
