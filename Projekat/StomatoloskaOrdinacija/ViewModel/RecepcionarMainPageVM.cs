using StomatoloskaOrdinacija.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using StomatoloskaOrdinacija.Model;
using StomatoloskaOrdinacija.View.Recepcionar;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class RecepcionarMainPageVM
    {
        
        public ICommand IzmjenaTerminaa { get; set; }
        public ICommand RegistrujPacijentaa { get; set; }
        public INavigationService NavigationService { get; set; }
        public RecepcionarMainPageVM()
        {
            IzmjenaTerminaa =  new RelayCommand<object>(IzmjenaTermina, MozeLiIzmjenaTermina);
            RegistrujPacijentaa = new RelayCommand<object>(RegistrujPacijenta, MozeLiRegistrujPacijenta);
            NavigationService = new NavigationService();
        }

        public bool MozeLiRegistrujPacijenta(object parametar)
        {
            return true;
        }
        public void RegistrujPacijenta(object parametar)
        {

            NavigationService.Navigate(typeof(RegistracijaPacijenta), parametar);

        }

        public bool MozeLiIzmjenaTermina(object parametar)
        {
            return true;
        }
        public  void IzmjenaTermina(object parametar)
        {

            NavigationService.Navigate(typeof(RecepcionarIzmjenaTermina),parametar);

        }
    }
}
