using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Admin:Osoblje
    {
        public Admin(string username, string password, string imeAdmina, string prezimeAdmina, DateTime datumRodjenjaAdmina) : base(imeAdmina, prezimeAdmina, datumRodjenjaAdmina)
        {
            Username = username;
            Password = password;
        }
        public Admin() { }
        private string Username { get; set; }
        private string Password { get; set; }

    }
}
