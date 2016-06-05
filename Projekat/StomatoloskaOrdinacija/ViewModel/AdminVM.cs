using StomatoloskaOrdinacija.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StomatoloskaOrdinacija.Model;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class AdminVM: INotifyPropertyChanged
    {
        private string imeOsoblja;
        private string prezimeOsoblja;
        private DateTimeOffset datumRodjenjaOsoblja;
        private string username;
        private string password;

        public string PasswordOsoblja
        {
            get { return password; }
            set
            {
                password = value;
                KadaSePromijeni("PasswordOsoblja");
            }
        }


        public string UsernameOsoblja
        {
            get { return username; }
            set
            {
                username = value;
                KadaSePromijeni("UsernameOsoblja");
            }
        }


        public DateTimeOffset DatumRodjenjaOsoblja
        {
            get { return datumRodjenjaOsoblja; }
            set {
                datumRodjenjaOsoblja = value;
                KadaSePromijeni("DatumRodjenjaOsoblja");
            }
        }


        public string PrezimeOsoblja
        {
            get { return prezimeOsoblja; }
            set
            {
                prezimeOsoblja = value;
                KadaSePromijeni("PrezimeOsoblja");
            }
        }


        public string ImeOsoblja
        {
            get { return imeOsoblja; }
            set
            {
                imeOsoblja = value;
                KadaSePromijeni("ImeOsoblja");
            }
        }

        public ICommand RegistrujStomatologaa { get; set; }
        public ICommand RegistrujRecepcionaraa { get; set; }


        public AdminVM()
        {
            RegistrujStomatologaa = new RelayCommand<object>(RegistrujStomatologa, MozeLiSeRegistrovatStomatolog);
            RegistrujRecepcionaraa = new RelayCommand<object>(RegistrujRecepcionara,MozeLiSeRegistrovatRecepcionar);
            datumRodjenjaOsoblja = new DateTimeOffset(DateTime.Now);

        }
        
        
        public event PropertyChangedEventHandler PropertyChanged;



        private void KadaSePromijeni(string podaci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(podaci));
        }

        public bool MozeLiSeRegistrovatStomatolog(object parametar)
        {
            return true;
        }
        public async  void RegistrujStomatologa(object parametar)
        {
           
           
           using(Model.OrdinacijaDBContext context = new OrdinacijaDBContext())
            {
                Model.Osoblje tmpOsoblje = new Osoblje(ImeOsoblja, PrezimeOsoblja, DatumRodjenjaOsoblja.Date) { Username = UsernameOsoblja, Password = PasswordOsoblja, TipOsoblja = "stomatolog" };
                context.Osobljee.AddRange(tmpOsoblje);
                context.SaveChanges();
                tmpOsoblje=context.Osobljee.LastOrDefault();

                Model.Stomatolog tmpStomatolog = new Stomatolog(UsernameOsoblja, PasswordOsoblja, ImeOsoblja, PrezimeOsoblja, DatumRodjenjaOsoblja.Date) { OsobljeID = tmpOsoblje.OsobljeID};
                context.Stomatolozi.AddRange(tmpStomatolog);
                await context.SaveChangesAsync();

            }

        }
        public bool MozeLiSeRegistrovatRecepcionar(object parametar)
        {
           
            return true;
           
        }
        public async void RegistrujRecepcionara(object parametar)
        {

            using (Model.OrdinacijaDBContext context = new OrdinacijaDBContext())
            {
                Model.Osoblje tmpOsoblje = new Osoblje(ImeOsoblja, PrezimeOsoblja, datumRodjenjaOsoblja.Date) { Username = UsernameOsoblja, Password = PasswordOsoblja, TipOsoblja = "recepcionar" };
                context.Osobljee.AddRange(tmpOsoblje);
                context.SaveChanges();
                tmpOsoblje = context.Osobljee.LastOrDefault();

                Model.Recepcionar tmpRecepcionar = new Recepcionar(UsernameOsoblja, PasswordOsoblja, ImeOsoblja, PrezimeOsoblja, DatumRodjenjaOsoblja.Date) { OsobljeID = tmpOsoblje.OsobljeID };
                context.Recepcionari.AddRange(tmpRecepcionar);
                await context.SaveChangesAsync();
                //var dialog = new MessageDialog("Recepcionar je u bazi..");
                //await dialog.ShowAsync();
            }

        }    

    }
}
