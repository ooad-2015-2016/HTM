using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Stomatolog:Osoblje
    {

        public Stomatolog(string username, string password, string imeStomatologa, string prezimeStomatologa, DateTime datumRodjenjaStomatologa) : base(imeStomatologa, prezimeStomatologa, datumRodjenjaStomatologa)
        {
            Username = username;
            Password = password;
            TipOsoblja = "Stomatolog";
        }
        public Stomatolog() { }

        public int StomatologID { get; set; }
        
    }
}
