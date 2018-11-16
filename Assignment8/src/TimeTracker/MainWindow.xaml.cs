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
        private IDateTime Time;

        public MainWindow()
        {
            InitializeComponent();

            Ticker = new DispatcherTimer();
            Time = new RealDateTime();

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
            if (!(ActiveTasksBox.SelectedItem is null))
            {
                ActiveTasksBox.Items.Remove(ActiveTasksBox.SelectedItem);
            }
        }

        private void DeleteFinishedTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(FinishedTasksBox.SelectedItem is null))
            {
                FinishedTasksBox.Items.Remove(FinishedTasksBox.SelectedItem);
            }
        }

        private void StopTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            if (!(ActiveTasksBox.SelectedItem is null))
            {
                Task completed = (Task)ActiveTasksBox.SelectedItem;
                completed.EndTime = Time.Now();
                ActiveTasksBox.Items.Remove(ActiveTasksBox.SelectedItem);
                FinishedTasksBox.Items.Add(completed);
            }
        }

        private void StartNewTaskButton_OnClick(object sender, RoutedEventArgs e)
        {
            string name = NewTaskNameBox.Text;

            if (!(name is null) && name.Length > 0)
            {
                ActiveTasksBox.Items.Add(new Task(name, Time));
                NewTaskNameBox.Text = "";
            }
        }
    }
}
