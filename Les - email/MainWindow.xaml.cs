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

namespace Les___email
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
            string fileLocation = @"C:\Users\migelle\Documents\Development\C# Advanced\files\e_mail.txt";
            string lines;
            string[] records;

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
                records = lines.Split(',');
                txtResultaat.Text += $"{records[0].Trim('"'),-30} {records[1].Trim('"')}" + Environment.NewLine;
            }

            sr.Close();
            
        }
    }
}
