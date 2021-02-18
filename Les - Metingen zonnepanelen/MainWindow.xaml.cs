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

namespace Les___Metingen_zonnepanelen
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

        private void MnuInlezenDetails_Click(object sender, RoutedEventArgs e)
        {
            string fileLocation = @"C:\Users\migelle\Documents\Development\C# Advanced\files\MetingenOpbrengstZonnepanelen.txt";
            string lines;
            StringBuilder str = new StringBuilder();


            StreamReader sr;

            try
            {
                sr = File.OpenText(fileLocation);
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
                str.Append(lines);
                str.Append(Environment.NewLine);
            }

            txtResultaat.Text = str.ToString();

            sr.Close();
        }

        private void MnuInlezenSamenvatting_Click(object sender, RoutedEventArgs e)
        {
            string fileLocation = @"C:\Users\migelle\Documents\Development\C# Advanced\files\MetingenOpbrengstZonnepanelen.txt";
            string lines;
            int[] maanden = new int[12];
            double[] totalen = new double[12];
            int maand;
            double gemiddelde;
            StringBuilder str = new StringBuilder();
            //13

            StreamReader sr;

            try
            {
                sr = File.OpenText(fileLocation);
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

                maand = Convert.ToInt32(lines.Substring(3, 2));
                gemiddelde = Convert.ToDouble(lines.Substring(13, 4));

                switch (maand)
                {
                    case 01:
                        maanden[0]++;
                        totalen[0] += gemiddelde;
                        break;
                    case 02:
                        maanden[1]++;
                        totalen[1] += gemiddelde;
                        break;
                    case 03:
                        maanden[2]++;
                        totalen[2] += gemiddelde;
                        break;
                    case 04:
                        maanden[3]++;
                        totalen[3] += gemiddelde;
                        break;
                    case 05:
                        maanden[4]++;
                        totalen[4] += gemiddelde;
                        break;
                    case 06:
                        maanden[5]++;
                        totalen[5] += gemiddelde;
                        break;
                    case 07:
                        maanden[6]++;
                        totalen[6] += gemiddelde;
                        break;
                    case 08:
                        maanden[7]++;
                        totalen[7] += gemiddelde;
                        break;
                    case 09:
                        maanden[8]++;
                        totalen[8] += gemiddelde;
                        break;
                    case 10:
                        maanden[9]++;
                        totalen[9] += gemiddelde;
                        break;
                    case 11:
                        maanden[10]++;
                        totalen[10] += gemiddelde;
                        break;
                    case 12:
                        maanden[11]++;
                        totalen[11] += gemiddelde;
                        break;
                }

                
            }

            for(int i = 0; i < maanden.Length; i++)
            {
                str.Append(maanden[i]);
                str.Append(" - ");
                str.Append((double)totalen[i] / maanden[i]);
                str.Append(Environment.NewLine);
            }
            sr.Close();

            txtResultaat.Text = str.ToString();
        }

        private void MnuDatumTonenVerbergen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void MnuAchtergrondInstellen_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
