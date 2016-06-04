using StomatoloskaOrdinacija.Helper;
using StomatoloskaOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Microsoft.Data.Entity;
using Microsoft.Data.Sqlite;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class StomatologListaPacijenataVM
    {
        public static List<Pacijent> Pacijenti { get; set; }
        private Stomatolog tmpStomatolog;
        public StomatologVM Parent { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string CoverImage { get; set; }
        public INavigationService NavigationService { get; set; }

        public ICommand Prikazii { get; set; }
        public ICommand Backk { get; set; }

        public StomatologListaPacijenataVM()
        {
            Prikazii = new RelayCommand<object>(Prikazi, MozeLiSePrikazati);
            Pacijenti = new List<Pacijent>();
            NavigationService = new NavigationService();
            //Parent = new StomatologVM();     
        }
        public StomatologListaPacijenataVM(StomatologVM trenutniStomatologVM)
        {
            Parent = trenutniStomatologVM;
            Prikazii = new RelayCommand<object>(Prikazi, MozeLiSePrikazati);
            Pacijenti = new List<Pacijent>();
            NavigationService = new NavigationService();
        }


        public bool MozeLiBack(object parametar)
        {
            return true;

        }
        public void Back(object parametar)
        {
            var frame = (Frame)Window.Current.Content;
            frame.GoBack();

            //Parent.NavigationService.GoBack();
        }

        public bool MozeLiSePrikazati(object parametar)
        {
            return true;
            //if(parametar!=null) return true;
            //return false;
        }
        //ovo radi kada se kao parametar proslijedi objekat tipa Stomatolog
        public void Prikazi(object parametar)
        {
            //tmpStomatolog = new Stomatolog() { StomatologID = 1 };
            tmpStomatolog = parametar as Stomatolog;

            using (var context = new OrdinacijaDBContext())
            {
                
                var zahvati = context.Zahvati.Where(z => z.StomatologIDuZahvatu.Equals(tmpStomatolog.StomatologID)).ToList();
                var tmpPacijenti = context.Pacijenti.ToList();

                foreach (Zahvat z in zahvati)
                    foreach (Pacijent p in tmpPacijenti)
                        if (z.PacijenIDuZahvatu.Equals(p.PacijentID)) Pacijenti.Add(p);
               
            }

        }

       
        public List<Pacijent> VratiSvePacijente(Stomatolog nekiStomatolog)
        {

            //var nekiStomatolog = new Stomatolog() { StomatologID = 1 };

            using (var context = new OrdinacijaDBContext())
            {

                var zahvati = context.Zahvati.Where(z => z.StomatologIDuZahvatu.Equals(nekiStomatolog.StomatologID)).ToList();
                var tmpPacijenti = context.Pacijenti.ToList();

                foreach (Zahvat z in zahvati)
                    foreach (Pacijent p in tmpPacijenti)
                        if (z.PacijenIDuZahvatu.Equals(p.PacijentID)) Pacijenti.Add(p);

            }
            //Parent.NavigationService.GoBack();
            return Pacijenti;

        }

    }
}
