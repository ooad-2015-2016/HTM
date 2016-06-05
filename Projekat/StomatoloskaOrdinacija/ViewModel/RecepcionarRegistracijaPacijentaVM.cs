using StomatoloskaOrdinacija.Helper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class RecepcionarRegistracijaPacijentaVM: INotifyPropertyChanged
    {
        private string ime;
        private string prezime;
        private DateTimeOffset datumRodjenja;
        private string username;
        private string password;
        private List<string> statusiPacijenata;
        public List<string> StatusiPacijenata
        {   get { return statusiPacijenata; }
            set
            {
                statusiPacijenata = value;
                KadaSePromijeni("StatusiPacijenata");
            }
        }

       

        public event PropertyChangedEventHandler PropertyChanged;

        private string statusPacijenta;

        public string StatusPacijenta
        {
            get { return statusPacijenta; }
            set { statusPacijenta = value; }
        }


        public string Password
        {
            get { return password; }
            set
            {
                password = value;
                KadaSePromijeni("Password");
            }
        }


        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                KadaSePromijeni("Username");
            }
        }


        public DateTimeOffset DatumRodjenja
        {
            get { return datumRodjenja; }
            set
            {
                datumRodjenja = value;
                KadaSePromijeni("DatumRodjenja");
            }
        }


        public string Prezime
        {
            get { return prezime; }
            set
            {
                prezime = value;
                KadaSePromijeni("Prezime");
            }
        }


        public string Ime
        {
            get { return ime; }
            set
            {
                ime = value;
                KadaSePromijeni("Ime");
            }
        }
        public ICommand RegistrujPacijentaa { get; set; }
        public RecepcionarRegistracijaPacijentaVM()
        {
            RegistrujPacijentaa = new RelayCommand<object>(RegistrujPacijenta, MozeLiRegistrujPacijenta);
            StatusiPacijenata = new List<string>() {"student","penzioner","obicni pacijent"};
            datumRodjenja = new DateTimeOffset(DateTime.Now);
        }
        private void KadaSePromijeni(string podaci)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(podaci));
        }

        public bool MozeLiRegistrujPacijenta(object parametar)
        {
            return true;
        }
        public async void RegistrujPacijenta(object parametar)
        {
                using(Model.OrdinacijaDBContext context = new Model.OrdinacijaDBContext())
            {
                Model.Pacijent tmpPacijent = new Model.Pacijent(Ime, Prezime, DatumRodjenja.DateTime) { StatusPacijenta=this.StatusPacijenta };

                context.Pacijenti.AddRange(tmpPacijent);
                await context.SaveChangesAsync();
                List<Model.Pacijent> tmpPacijenti = context.Pacijenti.ToList();

                if(Username!=String.Empty && Password != String.Empty)
                {
                    Model.Korisnik tmpKorisnik = new Model.Korisnik(Username, Password, tmpPacijent) { PacijentIDuKorisnik= tmpPacijenti.Last().PacijentID };
                    context.Korisnici.AddRange(tmpKorisnik);
                    await context.SaveChangesAsync();
                }

            }


            //using (Model.OrdinacijaDBContext context = new OrdinacijaDBContext())
            //{
            //    Model.Osoblje tmpOsoblje = new Osoblje(ImeOsoblja, PrezimeOsoblja, DatumRodjenjaOsoblja.Date) { Username = UsernameOsoblja, Password = PasswordOsoblja, TipOsoblja = "stomatolog" };
            //    context.Osobljee.AddRange(tmpOsoblje);
            //    context.SaveChanges();
            //    tmpOsoblje = context.Osobljee.LastOrDefault();

            //    Model.Stomatolog tmpStomatolog = new Stomatolog(UsernameOsoblja, PasswordOsoblja, ImeOsoblja, PrezimeOsoblja, DatumRodjenjaOsoblja.Date) { OsobljeID = tmpOsoblje.OsobljeID };
            //    context.Stomatolozi.AddRange(tmpStomatolog);
            //    await context.SaveChangesAsync();

            //}

        }
    }
}
