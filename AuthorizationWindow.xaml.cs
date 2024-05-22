using System;
using System.Collections.Generic;
using System.IO;
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

namespace AuthorizationApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class AuthorizationWindow : Window
    {
        public AuthorizationWindow()
        {
            InitializeComponent();
        }
        private void EnterButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Password = txtPassword.Text;
            string role = txtLogin.Text;


            if (!string.IsNullOrEmpty(Login) && !string.IsNullOrEmpty(Password))
            {
                StreamReader sr = new StreamReader("C://Users/Пользователь/Desktop/AuthorizationApp/File/Admins.txt");
                string[] words;
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    words = line.Split(';');

                    if ((Login== words[0]) && (Password == words[1]))
                    {
                        
                        MainWindow window = new MainWindow();
                        window.Show();
                        Close();
                    }
                   
                }
            }
            else
            {
                MessageBox.Show("Please enter both username and password.");
            }
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
            RegistrWindow registr = new RegistrWindow();
            registr.Show();
            this.Close();
        }
    }
}
