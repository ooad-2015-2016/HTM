using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Recepcionar:Osoblje
    {

        public Recepcionar(string username, string password, string imeRecepcionara, string prezimeRecepcionara, DateTime datumRodjenjaRecepcionara) : base(imeRecepcionara, prezimeRecepcionara, datumRodjenjaRecepcionara)
        {
            Username = username;
            Password = password;
        }
        public Recepcionar() { }
        private string Username { get; set; }
        private string Password { get; set; }

    }
}
