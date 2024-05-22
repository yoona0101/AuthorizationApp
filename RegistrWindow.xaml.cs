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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace AuthorizationApp
{
    /// <summary>
    /// Логика взаимодействия для RegistrWindow.xaml
    /// </summary>
    public partial class RegistrWindow : Window
    {
        public RegistrWindow()
        {
            InitializeComponent();
        }

        private void SignUpButton_Click(object sender, RoutedEventArgs e)
        {
            string Login = txtLogin.Text;
            string Password = txtPassword.Text;
            string newAdmin = $"{Login};{Password}";
            StreamWriter streamWriter = new StreamWriter("C://Users/Пользователь/Desktop/AuthorizationApp/File/Admins.txt",append:true);
            streamWriter.Write($"\n{newAdmin}");
            streamWriter.Close();
            MainWindow window = new MainWindow();
            window.Show();
            Close();
        }
    }
}
