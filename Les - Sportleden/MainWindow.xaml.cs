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

namespace Les___Sportleden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    /// 

    
    public partial class MainWindow : Window
    {
        private List<string> sportCodes = new List<string>();
        public static string gekozenSportCode;
        public static string gekozenSportNaam;
        public static string bestandsnaam = @"C:\Users\migelle\Documents\Development\C# Advanced\files\LedenSportKamp.txt";

        public MainWindow()
        {
            InitializeComponent();
            
        }

        private void Window_Initialized(object sender, EventArgs e)
        {
            VulListbox();
        }

        private void VulListbox()
        {
            string filepath = @"C:\Users\migelle\Documents\Development\C# Advanced\files\Sporten.txt";
            StreamReader reader = File.OpenText(filepath);
            string[] sporten;

            while (!reader.EndOfStream)
            {
                sporten = reader.ReadLine().Split(';');
                lstSportNamen.Items.Add($"{sporten[1].Trim('"')}");
                sportCodes.Add($"{sporten[0].Trim('"')}");
            }

            lstSportNamen.SelectedIndex = 0;
            reader.Close();
        }

        private void BtnToonLeden_Click(object sender, RoutedEventArgs e)
        {
            gekozenSportCode = sportCodes[lstSportNamen.SelectedIndex];
            gekozenSportNaam = lstSportNamen.SelectedItem.ToString();

            sportleden vensterSportleden = new sportleden();
            vensterSportleden.Show(); //show dialog blokkeert oorspronkelijk venster tot nieuw venster gesloten is
            
        }

        private void BtnToonLeden2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(Application.Current.Windows.Count > 1)
            {
                MessageBox.Show("sluit ander vesnter");
                e.Cancel = true;
            }
        }
    }
}
