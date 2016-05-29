using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StomatoloskaOrdinacija.Model;
using System.Windows.Input;
using Windows.UI.Popups;

namespace StomatoloskaOrdinacija.ViewModel
{
    class LoginVM
    {
        //OrdinacijaDBContext context = new OrdinacijaDBContext();
        //private void button_Click(object sender, RoutedEventArgs e)
        //{

        //}
        public string Username  { get; set; }
        public string Password { get; set; }
        public ICommand Prijava { get; set; }
        public LoginVM()
        {

        }
        public bool ImalKorisnika(string username, string password)
        {
            var context = new OrdinacijaDBContext();
            var Admini= context.Administratori.ToList();
            foreach (Admin tmpAdmin in Admini)
                if (username.Equals(tmpAdmin.Username) && (password.Equals(tmpAdmin.Password))) return true;

            return false;
        }
    }
}
