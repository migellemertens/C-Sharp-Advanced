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

namespace Les___ICT_woorden
{
    /// <summary>
    /// Interaction logic for Test.xaml
    /// </summary>
    public partial class Test : Window
    {
        public Test()
        {
            InitializeComponent();
        }

        private Random r = new Random();
        private int _willekeurigGetal;
        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            txtEngelsWoord.Clear();
            txtNederlandsWoord.Clear();

            _willekeurigGetal = r.Next(MainWindow.Engels.Count);

            txtEngelsWoord.Text = MainWindow.Engels[_willekeurigGetal];
        }

        private void btnControle_Click(object sender, RoutedEventArgs e)
        {
            if(txtNederlandsWoord.Text.ToLower() == MainWindow.Nederlands[_willekeurigGetal].ToLower())
            {
                MessageBox.Show("Correct!", "Correct", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
            else
            {
                MessageBox.Show("Fout!", "Fout", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
    }
}
