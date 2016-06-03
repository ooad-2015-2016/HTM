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
    public class AdminVM: INotifyPropertyChanged
    {
        private string imeOsoblja;
        private string prezimeOsoblja;
        private string datumRodjenjaOsoblja;
        private string username;
        private string password;

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


        public string DatumRodjenjaOsoblja
        {
            get { return datumRodjenjaOsoblja; }
            set { datumRodjenjaOsoblja = value; }
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
        public void RegistrujStomatologa(object parametar)
        {
            string s = "aaa";

        }
        public bool MozeLiSeRegistrovatRecepcionar(object parametar)
        {
            AdminVM tmpAdminPodaci = parametar as AdminVM;

            //if (String.IsNullOrEmpty(tmpAdminPodaci.ImeOsoblja)) return false;
            return true;
           
        }
        public void RegistrujRecepcionara(object parametar)
        {
            string s = "aaa";

        }

    }
}
