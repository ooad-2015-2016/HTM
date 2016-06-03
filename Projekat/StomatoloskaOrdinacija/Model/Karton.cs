using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Karton
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int KartonID { get; set; }
        public int ZahvatIDuKartonu { get; set; }
        public Zahvat Zahvat { get; set; }
        public Karton()
        {
            
        }
    }
}
