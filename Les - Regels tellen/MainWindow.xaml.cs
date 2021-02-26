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
using System.Windows.Forms;

namespace Les___Regels_tellen
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
            Microsoft.Win32.OpenFileDialog bestandzoeker = new Microsoft.Win32.OpenFileDialog();

            bestandzoeker.InitialDirectory = @"C:\Users\migelle\Documents\Development\C# Advanced\files";
            if(bestandzoeker.ShowDialog() == true)
            {
                txtBestand.Text = bestandzoeker.FileName;
            }
        }

        private void btnStartTellenRegels_Click(object sender, RoutedEventArgs e)
        {
            int aantal = RegelsTellenVanBestand(txtBestand.Text);
            if (aantal > -1)
            {
                txtResultaat.Text = "Bestand " + txtBestand.Text + " bevat " + aantal.ToString() + " records.";
            }
        }

        private void btnBladeren2_Click(object sender, RoutedEventArgs e)
        {
            FolderBrowserDialog mapkiezer = new FolderBrowserDialog();
            if(mapkiezer.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                txtMap.Text = mapkiezer.SelectedPath;
            }
        }

        private void btnTellen2_Click(object sender, RoutedEventArgs e)
        {
            string[] bestandsnamen;
            bestandsnamen = Directory.GetFiles(txtMap.Text);
            txtResultaat2.Text = $"in de map {txtMap.Text} zijn er {bestandsnamen.Length} bestanden \n";
            int totaalAantalRegels = 0;
            for (int i = 0; i < bestandsnamen.Length; i++)
            {
                totaalAantalRegels += RegelsTellenVanBestand(bestandsnamen[i]);
            }

            txtResultaat2.Text += $"In totaal voor alle files zijn er {totaalAantalRegels} regels";
        }

        private void btnTonenBestanden_Click(object sender, RoutedEventArgs e)
        {
            string[] bestandsnamen;
            bestandsnamen = Directory.GetFiles(txtMap.Text);
            txtResultaat2.Text = $"de bestanden uit {txtMap.Text} : \n\n";
            for(int i = 0; i < bestandsnamen.Length; i++)
            {
                txtResultaat2.Text += $"{System.IO.Path.GetFileName(bestandsnamen[i])}\n";
            }
        }

        private int RegelsTellenVanBestand(string text)
        {
            int teller = 0;
            StreamReader reader;
            string record;
            try
            {
                reader = File.OpenText(text);
                record = reader.ReadLine();
                while (!reader.EndOfStream)
                {
                    record = reader.ReadLine();
                    teller++;
                }
            }
            catch
            {
                System.Windows.MessageBox.Show("file not found");
                teller--;
            }

            return teller;
        }
    }
}
