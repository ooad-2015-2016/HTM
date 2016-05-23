using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Stomatolog:Osoblje
    {
        private string password;
        public Stomatolog(string password,string imeStomatologa, string prezimeStomatologa, DateTime datumRodjenjaStomatologa) : base(imeStomatologa, prezimeStomatologa, datumRodjenjaStomatologa)
        { this.password = password; }

        public void IzvrsiZahvat() { }
        public void UnosOpreme() { }
    }
}
