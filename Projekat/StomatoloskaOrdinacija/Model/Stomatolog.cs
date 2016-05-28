using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Stomatolog:Osoblje
    {

        public Stomatolog(string username, string password, string imeStomatologa, string prezimeStomatologa, DateTime datumRodjenjaStomatologa) : base(imeStomatologa, prezimeStomatologa, datumRodjenjaStomatologa)
        {
            Username = username;
            Password = password;
        }
        public Stomatolog() { }

        public int StomatologID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
    }
}
