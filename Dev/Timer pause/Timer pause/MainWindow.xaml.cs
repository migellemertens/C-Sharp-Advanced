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

namespace Timer_pause
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer pauze = new DispatcherTimer();
        private int counter = 3;
        public MainWindow()
        {
            InitializeComponent();

            pauze.Interval = TimeSpan.FromMilliseconds(1000);
            pauze.Tick += CountdownPauze;
        }

        private void CountdownPauze(object sender, EventArgs e)
        {
            counter--;
            if(counter == 0)
            {
                pauze.Stop();
                counter = 3;
                textLabel.Visibility = Visibility.Hidden;
            }
        }

        private void pauseButton_Click(object sender, RoutedEventArgs e)
        {
            textLabel.Visibility = Visibility.Visible;
            pauze.Start();
        }
    }
}
