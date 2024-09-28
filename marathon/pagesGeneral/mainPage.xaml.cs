using marathon.pagesMarathon;
using marathon.pagesRunner;
using marathon.pagesSponsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Lifetime;
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

namespace marathon.pagesGeneral
{
    public partial class mainPage : Page
    {
        public mainPage()
        {
            InitializeComponent();
            UpdateCurrentDate();
        }

        // Метод для отображения текущей даты
        private void UpdateCurrentDate()
        {
            CurrentDateTextBlock.Text = DateTime.Now.ToString("dddd, dd MMMM yyyy"); // Пример формата: "среда, 21 октября 2016"
        }
        private void IWantToBecomeARunner(object sender, RoutedEventArgs e)
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
