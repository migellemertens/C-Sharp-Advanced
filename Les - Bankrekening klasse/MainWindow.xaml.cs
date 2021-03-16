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

namespace Les___Bankrekening_klasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private Bankrekening mijnBankrekening;
        private Bankrekening nieuweBankrekening;
        public MainWindow()
        {
            InitializeComponent();

            mijnBankrekening = new Bankrekening();
            mijnBankrekening.Munteenheid = "US $";
            lblMunteenheid.Content = $"Stand rekening in {mijnBankrekening.Munteenheid}:";
            txtStand.Text = $"{mijnBankrekening.HuidigSaldo:0.00}";

            Bankrekening uwBankrekening = new Bankrekening("Eur");
            uwBankrekening.HuidigSaldo = 1202.7;
            MessageBox.Show($"uw bankrekeningsaldo: {uwBankrekening.HuidigSaldo}");

            Bankrekening onzeBankrekening = new Bankrekening("US $");
            onzeBankrekening.HuidigSaldo = 740.68;
            MessageBox.Show($"uw bankrekeningsaldo: {onzeBankrekening.HuidigSaldo}");
        }

        private void btnWisselMuntEenheid_Click(object sender, RoutedEventArgs e)
        {
            if(mijnBankrekening.Munteenheid == "Eur")
            {
                mijnBankrekening.Munteenheid = "US $";
            }
            else
            {
                mijnBankrekening.Munteenheid = "Eur";
            }
            lblMunteenheid.Content = $"Stand rekening in {mijnBankrekening.Munteenheid}:";
        }

        private void btnTonen_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show($"Munt: {nieuweBankrekening.Munteenheid} - saldo: {nieuweBankrekening.HuidigSaldo}");
        }

        private void txtBedrag_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.Key == Key.Enter)
            {
                if(txtBedrag.Text != "")
                {
                    mijnBankrekening.BedragWijzigen(Convert.ToDouble(txtBedrag.Text));
                    txtStand.Text = $"{mijnBankrekening.HuidigSaldo:0.00}";
                    txtBedrag.Clear();
                }
            }
        }
    }
}
