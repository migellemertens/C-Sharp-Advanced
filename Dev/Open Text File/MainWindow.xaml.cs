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

namespace Open_Text_File
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

        private void BtnBladeren_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
            string pathAndFilename = "";
            string path = "";
            string filename = "";

            if(ofd.ShowDialog() == true)
            {
                pathAndFilename = System.IO.Path.GetFullPath(ofd.FileName);
                path = System.IO.Path.GetDirectoryName(ofd.FileName);
                filename = System.IO.Path.GetFileName(ofd.FileName);
            }

            LblPathFilenameResultaat.Content = pathAndFilename;
            LblPathResultaat.Content = path;
            LblFileName.Content = filename;
        }
    }
}
