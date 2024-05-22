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
using AuthorizationApp.Classes;

namespace AuthorizationApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            
           
            
            List<string> wordsList = File.ReadAllLines("C://Users/Пользователь/Desktop/AuthorizationApp/File/Staff.txt").ToList();
           List<Product> product = new List<Product>();
            foreach (string line in wordsList)
            { 
                string[] words = line.Split(';');
                //product.Add(new Product { NameProduct = words[0] });
            }
           
            productList.ItemsSource = wordsList;



        }
        private void selectItem_Changed(object sender, SelectionChangedEventArgs e)
        {
            if(productList.SelectedItem is string prod)
            {
                StaffWindow staff = new StaffWindow();
                staff.Show();
               
            }
        }

        private void btnUser_ButtonClick(object sender, RoutedEventArgs e)
        {
            UserWindow user = new UserWindow();
            user.Show();
        }

        private void btnStaff_ButtonClick(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Я хз че тут делать надо");
        }

        private void btnExit_ButtonClick(object sender, RoutedEventArgs e)
        {
            AuthorizationWindow authorization= new AuthorizationWindow();
            authorization.Show();
            Close();
        }
    }
}
