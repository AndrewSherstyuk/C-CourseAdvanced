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

namespace Task4
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        //private void Window_Loaded(Object sender, RoutedEventHandler eventHandler)
        //{
        //    DispatcherTimer dt = new DispatcherTimer();
        //    dt.Interval = TimeSpan.FromSeconds(1);
        //    dt.Tick += dtTicker;
        //    dt.Start();
        //}

        
        //private void StopButtonClick(Object sender, RoutedEventArgs e)
        //{

        //}

        //private void ResetButtonClick(Object sender, RoutedEventArgs e)
        //{

        //}

        private int increment = 0;

        private void dtTicker(object sender, EventArgs e)
        {
            increment++;
            TimerLabel.Content = increment.ToString();
        }

        private void StartButton_Click_1(object sender, EventArgs e)
        {
            increment++;
            TimerLabel.Content = increment.ToString();
        }
    }
}
