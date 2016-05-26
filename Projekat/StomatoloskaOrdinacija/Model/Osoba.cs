using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public abstract class Osoba
    {

        public string Ime { get; set; }
        public string Prezime { get; set; }
        public DateTime DatumRodjenja { get; set; }

        public Osoba(string ime, string prezime, DateTime datumRodjenja)
        {
            Ime = ime;
            Prezime = prezime;
            DatumRodjenja = datumRodjenja;

        }
        public Osoba() { }

    }
}
