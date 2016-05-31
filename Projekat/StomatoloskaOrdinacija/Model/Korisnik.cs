using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Korisnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KorisnikID { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public Pacijent KorisnikMobilneApp { get; set; }

        public Korisnik(string username, string password, Pacijent pacijent)
        {
            KorisnikMobilneApp = pacijent;
        }
        public Korisnik() { }
    }
}
