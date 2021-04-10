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
using System.Windows.Shapes;

namespace Blad_Steen_Schaar_UI
{
    /// <summary>
    /// Interaction logic for ButtonTestWindow.xaml
    /// </summary>
    public partial class ButtonTestWindow : Window
    {
       
        public ButtonTestWindow()
        {
            InitializeComponent();
        }

        private void btnBlad_MouseEnter(object sender, MouseEventArgs e)
        {
            btnBladImage.Source = new BitmapImage(new Uri(@"img/blad_hover.png", UriKind.RelativeOrAbsolute));            
        }

        private void btnBlad_Click(object sender, RoutedEventArgs e)
        {
            btnBlad.BorderBrush = new SolidColorBrush(Colors.Red);
            btnBlad.BorderThickness = new Thickness(2, 2, 2, 2);
        }

        private void btnBlad_MouseLeave(object sender, MouseEventArgs e)
        {
            btnBladImage.Source = new BitmapImage(new Uri(@"img/blad.png", UriKind.RelativeOrAbsolute));
        }
    }
}
