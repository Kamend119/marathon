using marathon.pagesGeneral;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace marathon.pagesRunner
{
    public partial class runnerMenuPage : Page
    {
        public runnerMenuPage()
        {
            InitializeComponent();
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }

        private void registrationForTheMarathon(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new registrationMarathonPage());
        }

        private void editingProfile(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new runnerprofileEditingPage());
        }

        private void contacts(object sender, RoutedEventArgs e)
        {
            // всплывающие окно
        }

        private void myResults(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new myResultsMarathonsPage());
        }

        private void mySponsor(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mySponsorsPage());
        }
    }
}
