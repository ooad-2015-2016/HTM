using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatoloskaOrdinacija.Model;
using System.Windows.Input;
using StomatoloskaOrdinacija.Helper;
using System.ComponentModel;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class StomatologPopisOpremeVM: INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        private int kolicina;
        private string naziv;

        public int Kolicina
        {
            get { return kolicina; }
            set
            {
                kolicina = value;
                KadaSePromijeni("Kolicina");
            }
        }
        public string Naziv
        {
            get { return naziv; }
            set
            {
                naziv = value;
                KadaSePromijeni("Naziv");
            }
        }
        public Oprema TrenutnaOprema { get; set; }
        public ICommand Selektovanii { get; set; }
        public List<Oprema> ListaOpreme { get; set; }
        public StomatologPopisOpremeVM()
        {
            ListaOpreme = new List<Oprema>();
            Selektovanii= new RelayCommand<object>(Selektovani, MozeLiSelektovani);
        }
        private void KadaSePromijeni(string podaci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(podaci));
        }
    

        public bool MozeLiSelektovani(object parametar)
        {
            return true;
        }
        public  void Selektovani(object parametar)
        {

            TrenutnaOprema = parametar as Oprema;
            Naziv = TrenutnaOprema.Naziv;
            Kolicina = TrenutnaOprema.Kolicina;

        }


        public List<Oprema> VratiSvuOpremu()
        {

            using (var context = new OrdinacijaDBContext())
            {

                var oprema = context.Opreme.ToList();
                ListaOpreme = oprema;

            }

            return ListaOpreme;

        }

    }
}
