using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public class Autovakantie:Reis
    {
        public const int EXTRAPRIJSHUURAUTO = 10;

        private bool EigenWagen { get; set; } 


        public Autovakantie(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen, bool eigenWagen) : base(vertrekDatum, terugkeerDatum, aantalPersonen)
        {
              EigenWagen= eigenWagen;
        }



        public override double BerekenPrijs()
        {
            if (EigenWagen==true && AantalPersonen <= 5)
            {
                return base.BerekenPrijs() + (EXTRAPRIJSHUURAUTO * AantalPersonen);
            }
            else if (EigenWagen == true && AantalPersonen > 5)
            {
                return base.BerekenPrijs() + 2*(EXTRAPRIJSHUURAUTO * AantalPersonen);
            }


            else
            {
                return base.BerekenPrijs() ;

            }
        }
    }
}
