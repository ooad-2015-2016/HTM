using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    class ZakazaniTermin
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZakazaniTerminID { get; set; }
        public int ZakazaniTerminiID { get; set; }
        public List<DateTime> Termini { get; set; }
        public ZakazaniTermin()
        {
            Termini = new List<DateTime>();
        }
    }
}
