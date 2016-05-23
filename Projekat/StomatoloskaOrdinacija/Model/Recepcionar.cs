using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Recepcionar:Osoblje
    {
        private string password;
        public Recepcionar(string password, string imeRecepcionara, string prezimeRecepcionara, DateTime datumRodjenjaRecepcionara) : base(imeRecepcionara, prezimeRecepcionara, datumRodjenjaRecepcionara)
        { this.password = password; }
        //moguc interfejs za recepcionara...
        public void RegistrujPacijenta() { }
        public void IzmjenaTermina() { }
        public void PristupMobilnojApp() { }

    }
}
