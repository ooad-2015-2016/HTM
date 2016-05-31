using StomatoloskaOrdinacija.Helper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class AdminVM
    {
        public ICommand RegistrujStomatologaa { get; set; }

        public AdminVM()
        {
            RegistrujStomatologaa = new RelayCommand<object>(RegistrujStomatologa, MozeLiSeRegistrovatStomatolog);
        }

        public bool MozeLiSeRegistrovatStomatolog(object parametar)
        {
            return true;
        }
        public void RegistrujStomatologa(object parametar)
        {
            

        }

    }
}
