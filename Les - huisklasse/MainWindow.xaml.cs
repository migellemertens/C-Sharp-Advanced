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
using Microsoft.VisualBasic;

namespace Les___huisklasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Huis huis1;
        private Huis huis2 = new Huis();
        private Huis huis3;
        private Huis huis4;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnCreatie1_Click(object sender, RoutedEventArgs e)
        {
            string codeType = BepaalCodeType();

            huis1 = new Huis(txtLocatie.Text, Convert.ToDouble(txtLengte.Text), Convert.ToDouble(txtBreedte.Text), Convert.ToInt32(txtAantalVerdiepingen.Text), codeType);
            huis3 = huis1;
        }

        private string BepaalCodeType()
        {
            string returnwaarde = "";

            if(radOpen.IsChecked == true)
            {
                returnwaarde = "O";
            }
            if(radHalfOpen.IsChecked == true)
            {
                returnwaarde = "H";
            }
            else
            {
                returnwaarde = "G";
            }

            return returnwaarde;
        }

        private void btnVerhogen1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMeerdereVerhogen1_Click(object sender, RoutedEventArgs e)
        {
            string aantalBij;
            aantalBij = Microsoft.VisualBasic.Interaction.InputBox("Geef aantal verdiepingen");
            try
            {
                huis1.VerhoogAantalVerdiepingen(Convert.ToInt32(aantalBij));
            }
            catch
            {
                MessageBox.Show("geen geheel getal, verhoging niet doorgevoerd");
            }
        }

        private void btnVerlagen1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTonen1_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = huis1.InformatieVolledig();
        }

        private void btnTonen3_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = huis3.InformatieVolledig();
        }

        private void btnCreatie2_Click(object sender, RoutedEventArgs e)
        {
            string codeType = BepaalCodeType();
            huis2 = new Huis(txtLocatie.Text, Convert.ToDouble(txtLengte.Text), Convert.ToDouble(txtBreedte.Text), Convert.ToInt32(txtAantalVerdiepingen.Text), codeType);
            huis4 = huis2;
        }

        private void btnVerhogen2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnMeerdereVerhogen2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerlagen2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnTonen2_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = huis2.InformatieVolledig();
        }

        private void btnTonen4_Click(object sender, RoutedEventArgs e)
        {
            txtResultaat.Text = huis4.InformatieVolledig();
        }
    }
}
