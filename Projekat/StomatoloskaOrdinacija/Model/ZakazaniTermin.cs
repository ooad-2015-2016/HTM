using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class ZakazaniTermin
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZakazaniTerminID { get; set; }
        public DateTime Termini { get; set; }
        public int PacijentID { get; set; }
        public int StomatologID { get; set; }

        public ZakazaniTermin()
        {
            
        }
    }
}
