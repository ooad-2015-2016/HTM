using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class Pacijent:Osoba
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int PacijentId { get; set; }
        public string StatusPacijenta { get; set; }
        public Pacijent(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta) { }
        public Pacijent() { }


    }
}
