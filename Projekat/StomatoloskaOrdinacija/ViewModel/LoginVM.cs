﻿using StomatoloskaOrdinacija.Helper;
using StomatoloskaOrdinacija.Model;
using StomatoloskaOrdinacija.View;
using StomatoloskaOrdinacija.View.Admin;
using StomatoloskaOrdinacija.View.Recepcionar;
using StomatoloskaOrdinacija.View.Stomatolog;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Windows.UI.Popups;

namespace StomatoloskaOrdinacija.ViewModel
{
    public class LoginVM:INotifyPropertyChanged
    {
        
        private string username;
        private string password;
        public string Username
        {
            get { return username; }
            set
            {
                username = value;
                KadaSePromijeni("Username");
            }
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
        public ICommand Prijavaa { get; set; }
        public INavigationService NavigationService { get; set; }


        public LoginVM()
        {
            NavigationService = new NavigationService();
            Prijavaa=new RelayCommand<object>(LogujSe, MozeLiSeLogovati);
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void KadaSePromijeni(string usernamePassword)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(usernamePassword));
        }

        public bool MozeLiSeLogovati(object parametar)
        {
            
            if (parametar!=null)
            {
                var usernamePassword = parametar as String;
                if (String.IsNullOrEmpty(usernamePassword)) return false;
                return true;
            }
            return false;
        }
        public async void LogujSe(object parametar)
        {

            var context = new OrdinacijaDBContext();
            var osoblje = context.Osobljee.ToList();
            

            foreach (Osoblje tmpOsoblje in osoblje)
            if (username.Equals(tmpOsoblje.Username) && (password.Equals(tmpOsoblje.Password)))
                {
                    switch (tmpOsoblje.TipOsoblja)
                    {
                        case "Admin":
                            NavigationService.Navigate(typeof(AdminMainPage),tmpOsoblje as Admin);
                            break;
                        case "Stomatolog":
                            List<Stomatolog> tmpListaStomatologa = context.Stomatolozi.Where(s => s.OsobljeID.Equals(tmpOsoblje.OsobljeID)).ToList();
                            foreach (Stomatolog s in tmpListaStomatologa)
                                { if (s.OsobljeID == tmpOsoblje.OsobljeID)
                                    NavigationService.Navigate(typeof(StomatologMainPage), s );
                                 };
                            break;
                        case "Recepcionar":
                            NavigationService.Navigate(typeof(RecepcionarMainPage), tmpOsoblje as Recepcionar);
                            break;           
                    }
                } else
                {
                    var dialog = new MessageDialog("Pogrešno korisničko ime/šifra!");
                    await dialog.ShowAsync();
                }

             
        }
   
    }
}
