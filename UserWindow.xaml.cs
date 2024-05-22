using AuthorizationApp.Classes;
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
using System.Windows.Shapes;

namespace AuthorizationApp
{
    /// <summary>
    /// Логика взаимодействия для UserWindow.xaml
    /// </summary>
    public partial class UserWindow : Window
    {
        public UserWindow()
        {
            InitializeComponent();
            List<string> wordsList = File.ReadAllLines("C://Users/Пользователь/Desktop/AuthorizationApp/File/Users.txt").ToList();
            List<User> user = new List<User>();
            foreach (string line in wordsList)
            {
                string[] words = line.Split(';');
                //user.Add(new User { NameProduct = words[0] });
            }

            userList.ItemsSource = wordsList;
        }

    }
}
