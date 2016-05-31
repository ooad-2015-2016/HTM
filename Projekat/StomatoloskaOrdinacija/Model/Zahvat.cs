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
        //stomatolog koji vrši zahvat
        //pacijent na kojem se izvršava zahvat
        //private Stomatolog stomatolog;
        //private Pacijent pacijent;
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZahvatID { get; set; }
        public string ImeIPrezimePacijenta { get; set; }
        public string ImeIPrezimeStomatologa { get; set; }
        public DateTime DatumZahvata { get; set; }

        public void UnosZahvataUKarton() { }
    }
}
