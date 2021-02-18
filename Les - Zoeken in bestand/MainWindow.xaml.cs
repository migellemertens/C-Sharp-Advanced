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

namespace Les___Zoeken_in_bestand
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

        private void btnBladeren_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog bestandZoeker = new OpenFileDialog();
            bestandZoeker.InitialDirectory = @"C:\users\migelle\documents\development\C# Advanced";

            if(bestandZoeker.ShowDialog() == true)
            {
                txtBestand.Text = bestandZoeker.FileName;
            }
        }

        private void btnZoeken_Click(object sender, RoutedEventArgs e)
        {
            string regel;
            int aantalRegels = 0;
            int aantalRegelsMatch = 0;
            StreamReader sr;

            try
            {
                sr = File.OpenText(txtBestand.Text);
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);

                return;
            }

            while (!sr.EndOfStream)
            {
                regel = sr.ReadLine();
                aantalRegels++;

                if(regel.IndexOf(txtZoekString.Text) > -1)
                {
                    aantalRegelsMatch++;
                    txtResultaat.Text += regel + Environment.NewLine;
                }
            }
            sr.Close();

            txtResultaat.Clear();

            txtResultaat.Text += Environment.NewLine + "Totaal aantal regels: " + aantalRegels.ToString() + Environment.NewLine +
                "Aantal regels met de zoekstring " + txtZoekString.Text + ": " + aantalRegelsMatch.ToString();
        }
    }
}
