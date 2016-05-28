using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Osoblje : Osoba
    {
        public int OsobljeID { get; set; }
        public Osoblje(string imeOsoblja, string prezimeOsoblja, DateTime datumRodjenjaOsoblja) : base(imeOsoblja, prezimeOsoblja, datumRodjenjaOsoblja) { }
        public Osoblje() { }
    }
}
