using StomatoloskaOrdinacija.Helper;
using StomatoloskaOrdinacija.Model;
using StomatoloskaOrdinacija.View.Stomatolog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class StomatologVM
    {
        public Stomatolog Stomatolog { get; set; }
        public ICommand ListaPacijenataa { get; set; }
        public ICommand UnosZahvata { get; set; }
        public INavigationService NavigationService { get; set; }
        public StomatologVM()
        {
            ListaPacijenataa= new RelayCommand<object>(ListaPacijenata, MozeLiListaPacijenata);
            UnosZahvata= new RelayCommand<object>(Unos, MozeLiUnos);
            NavigationService = new NavigationService();
        }
        public bool MozeLiUnos(object parametar)
        {
            return true;
        }
        public void Unos(object parametar)
        {
            
            NavigationService.Navigate(typeof(StomatologUnosZahvata), parametar);

        }
        public bool MozeLiListaPacijenata(object parametar)
        {
            return true;
        }
        public void ListaPacijenata(object parametar)
        {
            
           NavigationService.Navigate(typeof(StomatologListaPacijenata),parametar);
           
        }
    }
}
