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
using System.IO;

namespace Les___Sportleden
{
    /// <summary>
    /// Interaction logic for sportleden.xaml
    /// </summary>
    public partial class sportleden : Window
    {
        public sportleden()
        {
            InitializeComponent();
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            this.Title = $"gekozen sporttak: {MainWindow.gekozenSportCode} - {MainWindow.gekozenSportNaam}";
            string bestandsnaam = MainWindow.bestandsnaam;

            StreamReader reader = File.OpenText(bestandsnaam);
            string record, naam, voornaam, sportcode, weeknummer;

            record = reader.ReadLine();
            while (!reader.EndOfStream)
            {
                naam = record.Substring(0, 30);
                voornaam = record.Substring(30, 30);
                sportcode = record.Substring(61, 3);
                weeknummer = record.Substring(60, 1);

                if (MainWindow.gekozenSportCode.Equals(sportcode))
                {
                    txtResultaat.Text += $"{naam.Trim()} {voornaam.Trim()} (Week {weeknummer})\n";
                }
                record = reader.ReadLine();
                
            }
            reader.Close();
        }
    }
}
