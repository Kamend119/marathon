using marathon.pagesCalculator;
using marathon.pagesGeneral;
using marathon.pagesRunner;
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

namespace marathon.pagesMarathon
{
    public partial class detailedInformationPage : Page
    {
        public detailedInformationPage()
        {
            InitializeComponent();
        }

        private void maraphonSkills(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new informationMarathonPage());
        }

        private void previousResults(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new resultPastRacesPage());
        }

        private void BMICalculate(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BMICalculatorPage());
        }

        private void BMRCalculate(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new BMRCalculatorPage());
        }

        private void listCharitableOrganizations(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new listCharitiesPage());
        }

        private void howLongMarathon(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new howLongMarathonPage());
        }

        private void BackToScrin(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new mainPage());
        }
    }
}
