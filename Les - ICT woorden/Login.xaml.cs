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
    /// Interaction logic for Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, RoutedEventArgs e)
        {
            if((txtGebruikersNaam.Text == "An" || txtGebruikersNaam.Text =="Jan") && paswoord.Password == "test")
            {
                MainWindow.gebruikersNaam = txtGebruikersNaam.Text;
                this.DialogResult = true;
            }
        }

        private void btnAnnuleer_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}
