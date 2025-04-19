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
using Ziyatdinova420_Shaitanet.DB;

namespace Ziyatdinova420_Shaitanet.Pages
{

    /// <summary>
    /// Логика взаимодействия для EnterPage.xaml
    /// </summary>
    public partial class EnterPage : Page
    {
        public static User users { get; set; }
        public static List<User> user { get; set; }
        public EnterPage()
        {
            InitializeComponent();
        }

        private void EnterBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FeedPage());
            //string _login = LoginTB.Text.Trim();
            //string _password = PasswordTB.Text.Trim();
            //user = new List<User>(DBConnection.Shaitanet_420Entities.User.ToList());
            //DBConnection.Shaitanet_420Entities.User = user.FirstOrDefault(x => x.Login == _login && x.Password == _password); // мы передаём текущего пользователя в глобальную переменную, и теперь можно вызвать его везед используя  App.employee
            //users = DBConnection.Shaitanet_420Entities.User.users;
            //if (DBConnection.Shaitanet_420Entities.User.user != null)
            //{
            //    MessageBox.Show($"Добро пожаловать {users.Name} !!!");
            //    if (users.ID_type == 1)
            //    {
            //        NavigationService.Navigate(new FeedPage());
            //    }
            //    else
            //        MessageBox.Show("Неверный логин или пароль!!!");

            //}
        }
    }
    }
