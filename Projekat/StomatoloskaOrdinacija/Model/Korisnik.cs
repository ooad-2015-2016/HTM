using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Korisnik
    {
        private string Username { get; set; }
        private string Password { get; set; }
        public Pacijent KorisnikMobilneApp { get; set; }

        public Korisnik(string username, string password, Pacijent pacijent)
        {
            KorisnikMobilneApp = pacijent;
        }
    }
}
