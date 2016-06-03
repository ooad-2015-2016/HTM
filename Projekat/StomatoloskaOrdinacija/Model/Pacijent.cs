using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Pacijent:Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PacijentID { get; set; }
        public string StatusPacijenta { get; set; }
        public byte[] Slika { get; set; }//slika pacijenta
        public Pacijent(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta) { }
        public Pacijent() { }


    }
}
