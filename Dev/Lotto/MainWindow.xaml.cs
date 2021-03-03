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

namespace Lotto
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

        private Random r = new Random();
        private void generateButton_Click(object sender, RoutedEventArgs e)
        {
            resultLabel.Content = "";
            int[] numbers = new int[6];
            int generatedNumber;

            for(int i = 0; i <numbers.Length;i++)
            {
                generatedNumber = r.Next(1, 46);

                foreach(int j in numbers)
                {
                    if(j == generatedNumber)
                    {
                        generatedNumber = r.Next(1, 46);
                    }
                }
                numbers[i] = generatedNumber;
            }

            foreach(int a in numbers)
            {
                resultLabel.Content += $"{a} - ";
            }
        }
    }
}
