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

namespace Blad_Steen_Schaar_UI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.MaxHeight = SystemParameters.MaximizedPrimaryScreenHeight;
        }

        private void BtnSluiten_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void BtnMaximize_Click(object sender, RoutedEventArgs e)
        {
            if(this.WindowState == WindowState.Maximized)
            {
                this.WindowState = WindowState.Normal;
                this.BorderThickness = new Thickness(0);
            }
            else
            {
                this.WindowState = WindowState.Maximized;
                this.BorderThickness = new Thickness(6);
            }
        }

        private void BtnMinimize_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

        private void Grid_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if(e.LeftButton == MouseButtonState.Pressed)
            {
                DragMove();
            }
        }

        private void BtnBlad_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("click blad worked");
            btnBlad.BorderBrush = new SolidColorBrush(Colors.SeaGreen);
            btnBlad.BorderThickness = new Thickness(2, 0, 0, 0);

            btnSchaar.BorderThickness = new Thickness(0);
            btnSteen.BorderThickness = new Thickness(0);

        }

        private void BtnSteen_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("click steen worked");

            btnSteen.BorderBrush = new SolidColorBrush(Colors.SeaGreen);
            btnSteen.BorderThickness = new Thickness(2, 0, 0, 0);

            btnSchaar.BorderThickness = new Thickness(0);
            btnBlad.BorderThickness = new Thickness(0);
        }

        private void BtnSchaar_Click(object sender, RoutedEventArgs e)
        {
            //MessageBox.Show("click schaar worked!");

            btnSchaar.BorderBrush = new SolidColorBrush(Colors.SeaGreen);
            btnSchaar.BorderThickness = new Thickness(2, 0, 0, 0);

            btnSteen.BorderThickness = new Thickness(0);
            btnBlad.BorderThickness = new Thickness(0);
        }

        private void btnBlad_MouseEnter(object sender, MouseEventArgs e)
        {
            imgButtonBlad.Source = new BitmapImage(new Uri(@"img/blad_hover.png", UriKind.RelativeOrAbsolute));
        }

        private void btnSteen_MouseEnter(object sender, MouseEventArgs e)
        {
            imgButtonSteen.Source = new BitmapImage(new Uri(@"img/steen_hover.png", UriKind.RelativeOrAbsolute));
        }

        private void btnSchaar_MouseEnter(object sender, MouseEventArgs e)
        {
            imgButtonSchaar.Source = new BitmapImage(new Uri(@"img/schaar_hover.png", UriKind.RelativeOrAbsolute));
        }

        private void btnBlad_MouseLeave(object sender, MouseEventArgs e)
        {
            imgButtonBlad.Source = new BitmapImage(new Uri(@"img/blad.png", UriKind.RelativeOrAbsolute));
        }

        private void btnSteen_MouseLeave(object sender, MouseEventArgs e)
        {
            imgButtonSteen.Source = new BitmapImage(new Uri(@"img/steen.png", UriKind.RelativeOrAbsolute));
        }

        private void btnSchaar_MouseLeave(object sender, MouseEventArgs e)
        {
            imgButtonSchaar.Source = new BitmapImage(new Uri(@"img/schaar.png", UriKind.RelativeOrAbsolute));
        }
    }
}
