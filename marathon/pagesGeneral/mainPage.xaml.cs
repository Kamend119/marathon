using marathon.pagesMarathon;
using marathon.pagesRunner;
using marathon.pagesSponsor;
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

namespace marathon.pagesGeneral
{
    public partial class mainPage : Page
    {
        public mainPage()
        {
            InitializeComponent();
        }
        private void IWantToBecomeARunner_Click(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new CheckRunnersPage());
        }

        private void IWantToSponsorARunner(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new runnerSponsorPage());
        }

        private void IWantToKnowMoreAboutTheEvent(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new detailedInformationPage());
        }

        private void Login(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new authorizationMenuPage());
        }
    }
}
