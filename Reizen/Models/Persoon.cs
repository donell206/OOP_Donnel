using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reizen.Models
{
    public class Persoon
    {
        public Adres Adres { get; set; }
        public string Familienaam { get; set; }
        public string Voornaam { get; set; }



        //public string Naam (string familienaam, string voornaam)
        //{
        //    this.Familienaam = familienaam;
        //    this.Voornaam = voornaam;
        //}


        public string Naam { get { return $"{Voornaam} {Familienaam}"; } }



    }
}
