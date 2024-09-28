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
    public partial class authorizationMenuPage : Page
    {
        public authorizationMenuPage()
        {
            InitializeComponent();
        }

        private void BackToScrin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }

        private void Login(object sender, RoutedEventArgs e)
        {

        }
    }
}
