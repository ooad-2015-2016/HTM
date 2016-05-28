﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Admin:Osoblje
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }
        private string Username { get; set; }
        private string Password { get; set; }
        public Admin(string username, string password, string imeAdmina, string prezimeAdmina, DateTime datumRodjenjaAdmina) : base(imeAdmina, prezimeAdmina, datumRodjenjaAdmina)
        {
            Username = username;
            Password = password;
        }

        public Admin() { }


    }
}
