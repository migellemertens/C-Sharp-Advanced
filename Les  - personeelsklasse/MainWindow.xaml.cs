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

namespace Les____personeelsklasse
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private List<Personeel> personeelslijst = new List<Personeel>();
        public MainWindow()
        {
            InitializeComponent();
            this.WindowState = WindowState.Maximized;

            string locatieTesktBestand = @"C:\Users\migelle\Documents\Development\C# Advanced\files\personeelsledenVoorGebruikInList.txt";
            string record;
            string[] delen;
            string naam, voornaam, geslacht;
            int beoordelingsCijfer;
            int startJaar;
            DateTime geboorteDatum;
            Personeel mijnPersoneelsLid;
            StreamReader reader;
            reader = File.OpenText(locatieTesktBestand);
            record = reader.ReadLine();
            while(reader != null)
            {
                delen = record.Split(',');
                naam = delen[0].Trim('"');
                voornaam = delen[1].Trim('"');
                geslacht = delen[2].Trim('"');
                beoordelingsCijfer = Convert.ToInt32(delen[3]);
                startJaar = Convert.ToInt32(delen[4]);
                geboorteDatum = Convert.ToDateTime(delen[5]);
                mijnPersoneelsLid = new Personeel(naam, voornaam, geslacht, beoordelingsCijfer, startJaar, geboorteDatum);
                personeelslijst.Add(mijnPersoneelsLid);
                record = reader.ReadLine();
            }
            reader.Close();
        }

        private void BtnToonGewoon()
        {
            txtResultaat.Text = $"gegevens in oorspronkelijke volgorde:";

            foreach(Personeel mijnPersoneelsLid in personeelslijst)
            {
                if (chkVerjaardagen.IsChecked == true)
                {
                    txtResultaat.Text += $"{mijnPersoneelsLid.Voornaam} {mijnPersoneelsLid.Naam} verjaart op {mijnPersoneelsLid.EerstvolgendeverjaardagTekst}\n";
                }
                txtResultaat.Text += mijnPersoneelsLid.InformatieVolledig();
            }
        }

        private void BtnToonOmgekeerdeVolgorde()
        {
            txtResultaat.Text = $"gegevens in omgekeerde volgorde:";

            for (int i = personeelslijst.Count - 1; i > -1; i--)
            {
                
                txtResultaat.Text += personeelslijst[i].InformatieVolledig();
            }
        }
    }
}
