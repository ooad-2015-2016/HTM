using StomatoloskaOrdinacija.Helper;
using StomatoloskaOrdinacija.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace StomatoloskaOrdinacija.ViewModel
{
    class StomatologUnosZahvataVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private string imePacijenta;
        private string prezimePacijenta;
        private string opisZahvataa;
        private DateTimeOffset datumZahvata;
        public ICommand Backk { get; set; }
        public bool MozeLiBack(object parametar)
        {
            return true;
        }
        public void Back(object parametar)
        {

            var frame = (Frame)Window.Current.Content;
            frame.GoBack();

        }

        public Stomatolog TrenutniStomatolog { get; set; }

        public string ImePacijenta
        {
            get { return imePacijenta; }
            set {
                    imePacijenta = value;
                    KadaSePromijeni("ImePacijenta");
                }
        }
        public string OpisZahvataa
        {
            get { return opisZahvataa; }
            set { opisZahvataa = value; KadaSePromijeni("OpisZahvata"); }
        }
        public string PrezimePacijenta
        {
            get { return prezimePacijenta; }
            set { prezimePacijenta = value; KadaSePromijeni("PrezimePacijenta"); }
        }
        public DateTimeOffset DatumZahvata
        {
            get { return datumZahvata; }
            set { datumZahvata = value; KadaSePromijeni("DatumZahvata"); }
        }
        public ICommand UnesiZahvata{ get; set; }

        public StomatologUnosZahvataVM()
        {
            UnesiZahvata = new RelayCommand<object>(UnesiZahvat, MozeLiSeUnijetZahvat);
            Backk= new RelayCommand<object>(Back, MozeLiBack);
            DatumZahvata = new DateTimeOffset(DateTime.Now);
        }

        private void KadaSePromijeni(string podaci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(podaci));
        }

        public bool MozeLiSeUnijetZahvat(object parametar)
        {
           
            if (parametar != null) return true;
            return false;
        }
        public async void UnesiZahvat(object parametar)
        {
            
            TrenutniStomatolog = parametar as Stomatolog;
            using (Model.OrdinacijaDBContext context = new OrdinacijaDBContext())
            {
                Pacijent tmpPacijent = new Pacijent();
                
                List<Pacijent> tmpListaPacijenata = context.Pacijenti.ToList();
                foreach (Pacijent p in tmpListaPacijenata)
                    if (p.Ime.ToLower().Equals(ImePacijenta.ToLower()) && (p.Prezime.ToLower().Equals(PrezimePacijenta.ToLower())))
                    {
                        tmpPacijent = p;

                        Zahvat tmpZahvat = new Zahvat() { Pacijent = tmpPacijent, Stomatolog = TrenutniStomatolog, PacijenIDuZahvatu = tmpPacijent.PacijentID, StomatologIDuZahvatu = TrenutniStomatolog.StomatologID, OpisZahvata = OpisZahvataa };
                        context.Zahvati.AddRange(tmpZahvat);
                        await context.SaveChangesAsync();
                        return;
                    }
                //ako nije tu onda treba ispisat poruku da je unio pogresnog pacijenta
                var dialog = new MessageDialog("pogrešan pacijent..");
                await dialog.ShowAsync();
            }

        }
    }
}
