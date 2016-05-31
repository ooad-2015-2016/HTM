using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Oprema
    {
        public int OpremaID { get; set; }
        public string Naziv { get; set; }
        public int Kolicina { get; set; }

        public Oprema() { }
    }
}
