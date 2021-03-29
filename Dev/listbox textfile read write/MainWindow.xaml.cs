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
using System.Windows.Threading;

namespace listbox_textfile_read_write
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private DispatcherTimer huidigeTijd = new DispatcherTimer();
        private List<string> resultatenlijst = new List<string>();
        public MainWindow()
        {
            InitializeComponent();

            huidigeTijd.Interval = TimeSpan.FromMilliseconds(1000);
            huidigeTijd.Tick += UpdateHuidigeTijd;
            huidigeTijd.Start();

            LeesResultatenIn();
            LaadResultatenInListbox();
        }

        private void LaadResultatenInListbox()
        {
            LstSpelerslijst.Items.Clear();
            foreach(string s in resultatenlijst)
            {
                LstSpelerslijst.Items.Add(s);
            }
        }

        private void UpdateHuidigeTijd(object sender, EventArgs e)
        {
            LblHuidigeTijd.Content = DateTime.Now.ToString("d/M/yyyy HH:mm:ss");
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            VoegNieuwResultaatToe();
        }

        private void LeesResultatenIn()
        {
            StreamReader sr = new StreamReader(@"C:\Users\migelle\Documents\Development\C# Advanced\Dev\listbox textfile read write\Historiek.txt");
            StringBuilder resultatenLijst = new StringBuilder();

            while (!sr.EndOfStream)
            {
                resultatenLijst.Append(sr.ReadLine());
                resultatenlijst.Add(resultatenLijst.ToString());
            }

            sr.Close();

        }

        private void VoegNieuwResultaatToe()
        {
            string speler = TxtSpelerNaam.Text;
            int scoreSpeler = Convert.ToInt32(TxtScoreSpeler.Text);
            int scoreComputer = Convert.ToInt32(TxtScoreComputer.Text);
            string huidigeTijd = DateTime.Now.ToString("d/M/yyyy HH:mm:ss");

            StringBuilder nieuwResultaat = new StringBuilder();
            nieuwResultaat.Append($"{speler,-10}");
            nieuwResultaat.Append(" - ");
            nieuwResultaat.Append("Computer: ");
            nieuwResultaat.Append($"{scoreSpeler}-{scoreComputer}");
            nieuwResultaat.Append("   ");
            nieuwResultaat.Append($"({huidigeTijd})");
            resultatenlijst.Insert(0,nieuwResultaat.ToString());

            LaadResultatenInListbox();

        }

        private void SchrijfResultaatWeg()
        {
            StreamWriter wr = new StreamWriter(@"C:\Users\migelle\Documents\Development\C# Advanced\Dev\listbox textfile read write\Historiek.txt");

            foreach(string s in resultatenlijst)
            {
                wr.WriteLine(s);
            }

            wr.Close();
        }

        private void BtnSlaResultaatOp_Click(object sender, RoutedEventArgs e)
        {
            SchrijfResultaatWeg();
        }
    }
}
