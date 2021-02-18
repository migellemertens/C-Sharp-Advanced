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
using System.IO;
using Microsoft.Win32;

namespace Les___Verwerken_vaste_lengte
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

        private void btnInlezen_Click(object sender, RoutedEventArgs e)
        {

            string lines;
            string bestand = @"C:\users\migelle\documents\development\C# Advanced\files\punten.txt";

            StreamReader sr;

            try
            {
                sr = File.OpenText(bestand);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);

                return; //verlaat en gaat verder naar volgende code
            }
            txtResultaat.Clear();

            while (!sr.EndOfStream)
            {
                lines = sr.ReadLine();
                txtResultaat.Text += lines + Environment.NewLine;
            }
        }

        private void btnVerwerken_Click(object sender, RoutedEventArgs e)
        {
            
            string bestand = @"C:\users\migelle\documents\development\C# Advanced\files\punten.txt";
            string uitvoerbestand = @"C:\users\migelle\documents\development\C# Advanced\files\verwerkt.txt";
            string invoerregel;
            string uitvoerregel = "";
            string naam;
            int behaaldResultaat;
            int teBehalenMaximaal;
            double percentage;

            StreamReader sr;
            StreamWriter sw;

            if(File.Exists(uitvoerbestand) == true)
            {
                if (MessageBox.Show("Bestand " + uitvoerbestand + " bestaat reeds. Overschrijven?", "overschrijven", MessageBoxButton.YesNo ) == MessageBoxResult.No)
                {
                    return;
                }
            }

            try
            {
                sr = File.OpenText(bestand);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);

                return; //verlaat en gaat verder naar volgende code
            }

            sw = File.CreateText(uitvoerbestand);
            txtResultaat.Clear();

            invoerregel = sr.ReadLine();

            while (invoerregel != null)
            {
                naam = invoerregel.Substring(0, 19);
                behaaldResultaat = Convert.ToInt32(invoerregel.Substring(48, 3));
                teBehalenMaximaal = Convert.ToInt32(invoerregel.Substring(51, 3));
                percentage = (double)behaaldResultaat / teBehalenMaximaal;
                uitvoerregel = naam + $"{percentage,5:0.00} ";

                if(percentage < 0.8)
                {
                    uitvoerregel += "niet ";
                }

                uitvoerregel += "geslaagd";

                sw.WriteLine(uitvoerregel);

                invoerregel = sr.ReadLine();
                
            }

            sr.Close();
            sw.Close();

            MessageBox.Show("Resultaten zijn verwerkt.", "succes", MessageBoxButton.OK, MessageBoxImage.Information);
        }

        private void btnNalezen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btnSluiten_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
