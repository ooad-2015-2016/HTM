using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Pacijent:Osoba
    {
        public string StatusPacijenta { get; set; }
        public Pacijent(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta) { }

        //moguc interfejs... poslije..
        public void ZakaziTermin() { }
        public void OtkaziTermin() { }
        public void OdaberiStomatologa() { }
        public void IspisKartona() { }
        public void PregledKarotna() { }
        public void PregledCjenovnika() { }
    }
}
