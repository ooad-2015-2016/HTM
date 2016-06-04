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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StomatoloskaOrdinacija.View.Admin
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class AdminMainPage : Page
    {
        public Model.Admin Admin { get; set; }
        public AdminMainPage()
        {
            this.InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            base.OnNavigatedTo(e);

            //Dobavljanje stomatologa iz parametra budući da je isti sa logina poslan kao parametar
            if (e.Parameter != null)
            {
                Admin = (Model.Admin)e.Parameter;
            }
        }

        private void CalendarDatePicker_DateChanged(CalendarDatePicker sender, CalendarDatePickerDateChangedEventArgs args)
        {

        }

        private void InnerFlyoutButton2_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout2.Hide();
        }

        private void InnerFlyoutButton_Click(object sender, RoutedEventArgs e)
        {
            MyFlyout.Hide();
        }
    }
}
