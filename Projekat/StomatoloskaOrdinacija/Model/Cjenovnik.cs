using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Cjenovnik
    { 
        public Dictionary<string,int> ListaCjenovnika { get; set; }
        public Cjenovnik()
        {
            ListaCjenovnika = new Dictionary<string, int>();
        }
    }
}
