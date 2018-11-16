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

namespace TimeTracker
{
    public partial class MainWindow : Window
    {
        private DispatcherTimer Ticker;

        public MainWindow()
        {
            InitializeComponent();

            Ticker = new DispatcherTimer();
            Ticker.Interval = TimeSpan.FromSeconds(1);
            Ticker.Tick += OnTimerTick;
            Ticker.Start();
        }

        private void OnTimerTick(object sender, EventArgs e)
        {
            CurrentTimeBox.Text = DateTime.Now.ToLongTimeString();
        }

        private void DeleteActiveTaskButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void DeleteFinishedTaskButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void StopTaskButton_OnClick(object sender, RoutedEventArgs e)
        {

        }

        private void StartNewTaskButton_OnClick(object sender, RoutedEventArgs e)
        {

        }
    }
}
