using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class Zahvat
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZahvatID { get; set; }
        public Pacijent Pacijent { get; set; }
        public int PacijenIDuZahvatu { get; set; }
        public int StomatologIDuZahvatu { get; set; }
        public Stomatolog Stomatolog { get; set; }
        public string OpisZahvata { get; set; }
        public DateTime DatumZahvata { get; set; }

        public void UnosZahvataUKarton() { }
    }
}
