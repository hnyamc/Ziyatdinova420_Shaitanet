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
    /// Логика взаимодействия для FeedPage.xaml
    /// </summary>
    public partial class FeedPage : Page
    {
        public FeedPage()
        {
            InitializeComponent();
            FeedLV.ItemsSource = DBConnection.Shaitanet_420Entities.Feed.ToList();
        }

        private void CollapseBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void CloseBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void FeedBTN_Click(object sender, RoutedEventArgs e)
        {

        }

        private void ExitBTN_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EnterPage());
        }

        private void AddBTN_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
