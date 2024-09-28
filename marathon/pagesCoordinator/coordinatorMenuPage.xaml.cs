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

namespace marathon.pagesCoordinator
{
    public partial class coordinatorMenuPage : Page
    {
        public coordinatorMenuPage()
        {
            InitializeComponent();
        }

        private void Logout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }

        private void Sponsors(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new sponsorOverviewMenuPage());
        }

        private void Runners(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new informationManagementRunnerPage());
        }
    }
}
