using marathon.pagesGeneral;
using marathon.pagesInventory;
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
using System.Windows.Threading;

namespace marathon.pagesAdministrator
{
    public partial class adminMenuPage : Page
    {
        public adminMenuPage()
        {
            InitializeComponent();
        }
        private void Logout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }

        private void users(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new managingUsersPage());
        }

        private void charitableOrganizations(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new managingCharitiesPage());
        }

        private void volunteers(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new managingVolunteersPage());
        }

        private void Inventory(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new inventoryPage());
        }
    }
}
