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

namespace PasswordBox_Dictionary
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int _passwordAttemptCounter = 0;
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginButton_Click(object sender, RoutedEventArgs e)
        {
            foreach(var user in Passwords.userLogins)
            {
                if(Equals(userNameTextBox.Text, user.Value) && (Equals(loginPasswordBox.Password, user.Key)))
                {
                    MessageBox.Show($"Password for user {userNameTextBox.Text} was correct", "Password OK", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
                else if(Equals(userNameTextBox.Text, user.Value) && !Equals(loginPasswordBox.Password, user.Key))
                {
                    _passwordAttemptCounter++;
                    if (_passwordAttemptCounter == 3)
                    {
                        MessageBox.Show($"You have used {_passwordAttemptCounter} attempts. The application will now close.", "Login Error", MessageBoxButton.OK, MessageBoxImage.Error);
                        this.Close();
                    }
                    else
                    {
                        loginPasswordBox.Clear();
                    }
                }
            }
        }
    }
}
