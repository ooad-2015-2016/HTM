using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.Model
{
    public class ObicniPacijent:Pacijent
    {
        public ObicniPacijent(string imePacijenta, string prezimePacijenta, DateTime datumRodjenjaPacijenta) : base(imePacijenta, prezimePacijenta, datumRodjenjaPacijenta)
        {
            StatusPacijenta = "ObicniPacijent";
        }
        public ObicniPacijent() { }
    }
}
