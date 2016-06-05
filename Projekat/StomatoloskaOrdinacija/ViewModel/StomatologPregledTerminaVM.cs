using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatoloskaOrdinacija.Model;

namespace StomatoloskaOrdinacija.ViewModel
{
   public class StomatologPregledTerminaVM
    {
        public List<ZakazaniTermin> TerminiTrenutnogStomatologa { get; set; }
        public StomatologPregledTerminaVM()
        {
            TerminiTrenutnogStomatologa = new List<ZakazaniTermin>();
        }
        public List<ZakazaniTermin> VratiSveTermine(Stomatolog nekiStomatolog)
        {

            //var nekiStomatolog = new Stomatolog() { StomatologID = 1 };

            using (var context = new OrdinacijaDBContext())
            {

                var termini = context.ZakazaniTermini.Where(z => z.StomatologID.Equals(nekiStomatolog.StomatologID)).ToList();
                TerminiTrenutnogStomatologa = termini;
                //foreach (ZakazaniTermin z in termini) TerminiTrenutnogStomatologa.Add(z.Termini);

                //var tmpPacijenti = context.Pacijenti.ToList();

                //foreach (Zahvat z in zahvati)
                //    foreach (Pacijent p in tmpPacijenti)
                //        if (z.PacijenIDuZahvatu.Equals(p.PacijentID)) Pacijenti.Add(p);

            }
            //Parent.NavigationService.GoBack();
            return TerminiTrenutnogStomatologa;

        }

    }
}
