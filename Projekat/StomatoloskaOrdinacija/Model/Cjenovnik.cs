using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Cjenovnik
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CjenovnikID { get; set; }
        public float Cijena { get; set; }
        public string NazivUsluge { get; set; }

    }
}
