using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using StomatoloskaOrdinacija.Model;
using StomatoloskaOrdinacija.ViewModel;
using Windows.UI.Core;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StomatoloskaOrdinacija.View.Stomatolog
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    /// 
    public sealed partial class StomatologListaPacijenata : Page
    {
        public List<Model.Pacijent> Pacijenti;
        public Model.Stomatolog Stomatolog { get; set; }
        public StomatologListaPacijenata()
        {
            this.InitializeComponent();

        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested -= ThisPage_BackRequested;
        }

        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //Dobavljanje stomatologa iz parametra budući da je isti sa logina poslan kao parametar
            if (e.Parameter != null)
            {
                Stomatolog = (Model.Stomatolog)e.Parameter;
                Pacijenti = new ViewModel.StomatologListaPacijenataVM().VratiSvePacijente(Stomatolog);
            }

            var currentView = SystemNavigationManager.GetForCurrentView();
            currentView.AppViewBackButtonVisibility = AppViewBackButtonVisibility.Visible;
            SystemNavigationManager.GetForCurrentView().BackRequested += ThisPage_BackRequested;

        }

        private void ThisPage_BackRequested(object sender, BackRequestedEventArgs e)
        {
                if (Frame.CanGoBack) { Frame.GoBack(); e.Handled = true;}  
        }
    }
}
