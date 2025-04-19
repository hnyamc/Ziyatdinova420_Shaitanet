using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
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
using Microsoft.Win32;
using Ziyatdinova420_Shaitanet.DB;

namespace Ziyatdinova420_Shaitanet.Pages
{
    /// <summary>
    /// Логика взаимодействия для AddFeedPage.xaml
    /// </summary>
    public partial class AddFeedPage : Page
    {
        public OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
        };
        public Feed feed = new Feed();
        private Feed feeds;
        public AddFeedPage()
        {
            InitializeComponent();
        }

        private void AddFeedBTN_Click(object sender, RoutedEventArgs e)
        {
            feed.Photo = File.ReadAllBytes(openFileDialog.FileName);
            feeds.Name = NameTB.Text;
            feeds.Description = DescriptionTB.Text;
            
            DBConnection.Shaitanet_420Entities.SaveChanges();
            MessageBox.Show("Данные успешно добавлены");

            //DBConnection.Shaitanet_420Entities.Feed.Add(feeds);
            //DBConnection.Shaitanet_420Entities.SaveChanges();
            //MessageBox.Show("Данные успешно добавлены");
            NavigationService.Navigate(new FeedPage());
        }

        private void Button_Click_EditPhoto(object sender, RoutedEventArgs e)
        {
            
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                feed.Photo = File.ReadAllBytes(openFileDialog.FileName);
                PhotoIM.Source = new BitmapImage(new Uri(openFileDialog.FileName));

            }
            MessageBox.Show("Фото выбрано)");
        }


        private void AddPhotoBTN_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog()
            {
                Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
            };
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                feed.Photo = File.ReadAllBytes(openFileDialog.FileName);// обращение к базе данных
                PhotoIM.Source = new BitmapImage(new Uri(openFileDialog.FileName));//обращение к картинке в вёрстке 
            }
        }
    }
}
