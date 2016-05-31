using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Recepcionar:Osoblje
    {

        public Recepcionar(string username, string password, string imeRecepcionara, string prezimeRecepcionara, DateTime datumRodjenjaRecepcionara) : base(imeRecepcionara, prezimeRecepcionara, datumRodjenjaRecepcionara)
        {
            Username = username;
            Password = password;
            TipOsoblja = "Recepcionar";
        }

        public Recepcionar() { }
        public int RecepcionarID { get; set; }
        

    }
}
