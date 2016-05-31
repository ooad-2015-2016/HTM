using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
   public class Admin:Osoblje
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AdminID { get; set; }
        
        public Admin(string username, string password, string imeAdmina, string prezimeAdmina, DateTime datumRodjenjaAdmina) : base(imeAdmina, prezimeAdmina, datumRodjenjaAdmina)
        {
            Username = username;
            Password = password;
            TipOsoblja = "Admin";
        }

        public Admin() { }


    }
}
