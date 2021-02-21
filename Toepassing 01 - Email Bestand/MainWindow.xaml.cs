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

namespace Toepassing_01___Email_Bestand
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

        private void BtnInlezen_Click(object sender, RoutedEventArgs e)
        {
            string bestandsnaam = @"C:\Users\migelle\Documents\Development\C# Advanced\files\e_mai.txt";

            try
            {
                Inlezenbestand(bestandsnaam);
            }
            catch (FileNotFoundException)
            {
                MessageBox.Show("File not found", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
            }
            
        }

        private void BtnInlezenDialoogvenster_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnInlezenDictionary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnWegschrijvenDictionary_Click(object sender, RoutedEventArgs e)
        {

        }

        private void BtnToevoegen_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Inlezenbestand(string bestandsnaam)
        {
            StringBuilder inlezenBestand = new StringBuilder();
            StreamReader reader = new StreamReader(bestandsnaam);
            string[] records;

            while (!reader.EndOfStream)
            {
                records = reader.ReadLine().Split(',');
                inlezenBestand.Append($"{records[0].Trim('"'),-25}");
                inlezenBestand.Append(": ");
                inlezenBestand.Append(records[1].Trim('"'));
                inlezenBestand.Append(Environment.NewLine);

            }

            reader.Close();

            TxtResultaat.Text = inlezenBestand.ToString();
        }
    }
}
