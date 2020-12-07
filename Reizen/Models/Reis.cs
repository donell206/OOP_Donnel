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
        private int aantalDagen;

        protected Reis(DateTime vertrekDatum, DateTime terugkeerDatum, int aantalPersonen)
        {
            this.vertrekDatum = vertrekDatum;
            this.terugkeerDatum = terugkeerDatum;
            AantalPersonen = aantalPersonen;
        }

        public int AantalDagen
        {
            get { return this.aantalDagen; }
            set
            {
                int val= Convert.ToInt16(terugkeerDatum - vertrekDatum);
                this.aantalDagen = val;
                //else cw please enter
            }
        }


        public int AantalPersonen { get; set; }
        //public DateTime TerugkeerDatum { get; set; }
       
        
        public DateTime VertrekDatum
        { 
            get{return this.vertrekDatum; } 
            set
            {
                    if (this.vertrekDatum < TerugkeerDatum)
                        this.vertrekDatum = value;
                    //else cw please enter
                } 
        }

        public DateTime TerugkeerDatum 
        { 
            get{return this.terugkeerDatum; }
            set
            {
                    if (this.terugkeerDatum > vertrekDatum)
                        this.terugkeerDatum = value;
            }
        }


       
        public virtual double BerekenPrijs()
        {

            return BASISDAGPRIJS * AantalDagen;
        }

    }
}








