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

        // private Zahvat z;
        public virtual ICollection<Zahvat> Zahvati { get; set; }
        public Karton()
        {
            Zahvati = new List<Zahvat>();
        }
    }
}
