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

namespace Les___ICT_woorden
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static string gebruikersNaam = "";
        private string bestandsNaam = @"C:\Users\migelle\Documents\Development\C# Advanced\files\WoordenboekICT.txt";
        public static List<string> Engels = new List<string>();
        public static List<string> Nederlands = new List<string>();
        bool onmiddelijkAfsluiten = true;
        public MainWindow()
        {
            InitializeComponent();
            Login loginWindow = new Login();
            if (loginWindow.ShowDialog() == false)
            {
                this.Close();
            }
            else
            {
                this.Title = $"Gebruiker: {gebruikersNaam}";
            }
            
        }

        private void btnToevoegen_Click(object sender, RoutedEventArgs e)
        {
            if(txtWoordEngels.Text != "" && txtWoordNederlands.Text != "")
            {
                Engels.Add(txtWoordEngels.Text);
                Nederlands.Add(txtWoordNederlands.Text);
                lstWoorden.Items.Add($"{txtWoordEngels} - {txtWoordNederlands}");
            }
            else
            {
                MessageBox.Show("EN en NL moet ingevuld zijn", "Geen tekst", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnVerwijderen_Click(object sender, RoutedEventArgs e)
        {
            int geselecteerdItem = lstWoorden.SelectedIndex;

            if(lstWoorden.SelectedIndex > -1)
            {
                lstWoorden.Items.RemoveAt(geselecteerdItem);
                Engels.RemoveAt(geselecteerdItem);
                Nederlands.RemoveAt(geselecteerdItem);
            }
            else
            {
                MessageBox.Show("geen item geselecteerd", "no selection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnVerbeteren_Click(object sender, RoutedEventArgs e)
        {
            int geselecteerdItem = lstWoorden.SelectedIndex;

            if (lstWoorden.SelectedIndex > -1)
            {

                txtWoordEngels.Text = Engels[geselecteerdItem];
                txtWoordNederlands.Text = Nederlands[geselecteerdItem];
            }
            else
            {
                MessageBox.Show("geen item geselecteerd", "no selection", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void btnWegschrijvenVerbetering_Click(object sender, RoutedEventArgs e)
        {
            int geselecteerdItem = lstWoorden.SelectedIndex;

            if(geselecteerdItem > -1 && txtWoordEngels.Text != "" && txtWoordNederlands.Text != "")
            {
                Engels[geselecteerdItem] = txtWoordEngels.Text;
                Nederlands[geselecteerdItem] = txtWoordNederlands.Text;
                lstWoorden.Items[geselecteerdItem] = $"{txtWoordEngels.Text} - {txtWoordNederlands}";
            }
            else
            {
                MessageBox.Show("EN en NL moet ingevuld zijn", "Geen tekst", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void MnuInlezen_Click(object sender, RoutedEventArgs e)
        {
            StreamReader reader;
            
            string[] delen;
            string woordEngels;
            string woordNederlands;

            if(Engels.Count > 0)
            {
                if (MessageBox.Show("overschrijven?", "overschrijven", MessageBoxButton.YesNo) == MessageBoxResult.No)
                {
                    return;
                }
            }
            

            if(File.Exists(bestandsNaam) == false)
            {
                MessageBox.Show($"{bestandsNaam} bestaat niet", "File not found", MessageBoxButton.OK, MessageBoxImage.Error);
                return;
            }

            lstWoorden.Items.Clear();
            Engels.Clear();
            Nederlands.Clear();
            reader = File.OpenText(bestandsNaam);

            while (!reader.EndOfStream)
            {
                delen = reader.ReadLine().Split(',');
                woordEngels = delen[0].Trim('"');
                woordNederlands = delen[1].Trim('"');
                lstWoorden.Items.Add($"{woordEngels} - {woordNederlands}");

                Engels.Add(woordEngels);
                Nederlands.Add(woordNederlands);

            }
            reader.Close();
            lstWoorden.SelectedIndex = 0;
            onmiddelijkAfsluiten = false;
        }

        private void MnuBewaren_Click(object sender, RoutedEventArgs e)
        {
            StreamWriter writer;
            string regel;

            if(MessageBox.Show("gegevens overschrijven?", "overschrijven?", MessageBoxButton.YesNo) == MessageBoxResult.Yes)
            {
                writer = File.CreateText(bestandsNaam);
                for(int i = 0; i < Engels.Count; i++)
                {
                    regel = $"\"{Engels[i]}\",\"{Nederlands[i]}\"";
                    writer.WriteLine(regel);
                }

                writer.Close();
            }
        }

        private void MnuOefenen_Click(object sender, RoutedEventArgs e)
        {
            Test testWindow = new Test();
            testWindow.ShowDialog();
        }

        private void Window_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (!onmiddelijkAfsluiten)
            {
                if (MessageBox.Show("Zijn jullie gegevens bewaard?", "Are you sure", MessageBoxButton.YesNo) == MessageBoxResult.No)
                {
                    e.Cancel = true;
                }
            }
            
        }
    }
}
