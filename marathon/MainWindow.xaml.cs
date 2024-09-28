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

namespace marathon
{
    public partial class MainWindow : Window
    {
        private DateTime marathonDate = new DateTime(2025, 10, 24); // Дата марафона
        public MainWindow()
        {
            InitializeComponent();
            MainFrame.Navigate(new mainPage());
            StartCountdown();
        }

        // Метод для обратного отсчета времени до марафона
        private void StartCountdown()
        {
            DispatcherTimer timer = new DispatcherTimer();
            timer.Interval = TimeSpan.FromSeconds(1);
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        // Обновление текста с обратным отсчетом
        private void Timer_Tick(object sender, EventArgs e)
        {
            TimeSpan timeRemaining = marathonDate - DateTime.Now;

            if (timeRemaining.TotalSeconds > 0)
            {
                CountdownTextBlock.Text = string.Format("{0} дней {1} часов и {2} минут до старта марафона!",
                    timeRemaining.Days, timeRemaining.Hours, timeRemaining.Minutes);
            }
            else
            {
                CountdownTextBlock.Text = "Марафон уже начался!";
            }
        }
    }
}
