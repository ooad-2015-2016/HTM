using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Zahvat
    {
        //stomatolog koji vrši zahvat
        //pacijent na kojem se izvršava zahvat
        //private Stomatolog stomatolog;
        //private Pacijent pacijent;
        public string ImeIPrezimePacijenta { get; set; }
        public string ImeIPrezimeStomatologa { get; set; }

        public void UnosZahvataUKarton() { }
    }
}
