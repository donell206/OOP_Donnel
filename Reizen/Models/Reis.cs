using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public abstract class Reis
    {
        public readonly int BASISDAGPRIJS = 40;
        
        private DateTime vertrekDatum;
        private DateTime terugkeerDatum;


        protected Reis(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
        {
            this.vertrekDatum = vertrekDatum;
            this.terugkeerDatum = terugkeerDatum;
            AantalPersonen = aantalPersonen;
        }

        public int AantalDagen
        {
            get{ return (int)Math.Round((TerugkeerDatum - VertrekDatum).TotalDays);}
        }


        public int AantalPersonen { get; set; }
        //public DateTime TerugkeerDatum { get; set; }
       
        
        public DateTime VertrekDatum
        { 
            get{return this.vertrekDatum; } 
            set
            {
                    if (value> DateTime.Now)
                        this.vertrekDatum = value;
                } 
        }

        public DateTime TerugkeerDatum 
        { 
            get{return this.terugkeerDatum; }
            set
            {
                    if (value > DateTime.Now && value> vertrekDatum)
                        this.terugkeerDatum = value;
            }
        }


       
        public virtual double BerekenPrijs()
        {

            return BASISDAGPRIJS * AantalDagen;
        }

    }
}








