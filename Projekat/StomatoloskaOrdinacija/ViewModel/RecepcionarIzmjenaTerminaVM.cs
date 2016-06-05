using StomatoloskaOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class RecepcionarIzmjenaTerminaVM
    {
        public List<ZakazaniTermin> TerminiTrenutnogStomatologa { get; set; }
        public RecepcionarIzmjenaTerminaVM()
        {
            TerminiTrenutnogStomatologa = new List<ZakazaniTermin>();
        }
        public List<ZakazaniTermin> VratiSveTermine()
        {
            using (var context = new OrdinacijaDBContext())
            {

                var termini = context.ZakazaniTermini.ToList();
                TerminiTrenutnogStomatologa = termini;
                

            }
            return TerminiTrenutnogStomatologa;

        }
    }
}
