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
        public INavigationService NavigationService { get; set; }
        public StomatologVM()
        {
            ListaPacijenataa= new RelayCommand<object>(ListaPacijenata, MozeLiListaPacijenata);
            NavigationService = new NavigationService();
        }
        public bool MozeLiListaPacijenata(object parametar)
        {
            return true;
        }
        public void ListaPacijenata(object parametar)
        {
            Stomatolog = parametar as Stomatolog;
           NavigationService.Navigate(typeof(StomatologListaPacijenata),parametar);
           

        }
    }
}
