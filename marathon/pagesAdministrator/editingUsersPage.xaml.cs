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
using System.Windows.Threading;

namespace marathon.pagesAdministrator
{
    public partial class editingUsersPage : Page
    {
        public editingUsersPage()
        {
            InitializeComponent();
        }
        private void Logout(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }

        private void BackToScrin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new managingUsersPage());
        }

        private void Save(object sender, RoutedEventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void cmbRole_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void Password_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void RepeatPassword_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
