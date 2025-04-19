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
using Microsoft.Win32;
using Ziyatdinova420_Shaitanet.DB;

namespace Ziyatdinova420_Shaitanet.Pages
{
    /// <summary>
    /// Логика взаимодействия для EditFeedPage.xaml
    /// </summary>
    public partial class EditFeedPage : Page
    {
        private Feed feed = new Feed();
        private int number = 0;
        public OpenFileDialog openFileDialog = new OpenFileDialog()
        {
            Filter = "*.png|*.png|*.jpeg|*.jpeg|*.jpg|*.jpg"
        };
        public EditFeedPage(Feed selecFeed)
        {
            InitializeComponent();
            feed = selecFeed;
            NameTB.Text = selecFeed.Name.ToString();
            DescriptionTB.Text = selecFeed.Description.ToString();
            PhotoIM.Source = ByteArrayToImage(feed.Photo);

        }

        private ImageSource ByteArrayToImage(byte[] imageData)
        {
            if (imageData == null || imageData.Length == 0)
                return null;

            using (var stream = new MemoryStream(imageData))
            {
                var bitmapImage = new BitmapImage();
                bitmapImage.BeginInit();
                bitmapImage.CacheOption = BitmapCacheOption.OnLoad;
                bitmapImage.StreamSource = stream;
                bitmapImage.EndInit();
                bitmapImage.Freeze();
                return bitmapImage;
            }
        }

        private void EditPhotoBTN_Click(object sender, RoutedEventArgs e)
        {
            if (openFileDialog.ShowDialog().GetValueOrDefault())
            {
                feed.Photo = File.ReadAllBytes(openFileDialog.FileName);
                PhotoIM.Source = new BitmapImage(new Uri(openFileDialog.FileName));

            }
            MessageBox.Show("Вы успешно выбрали новое фото!!!");
        }


        private void Button_Click_Back(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FeedPage());
        }
    

        private void EditFeedBTN_Click(object sender, RoutedEventArgs e)
        {
            feed.Name= NameTB.Text;
            feed.Description= DescriptionTB.Text;
            feed.Photo = File.ReadAllBytes(openFileDialog.FileName);
            if (number == 1)
            {
                DBConnection.Shaitanet_420Entities.Feed.Add(feed);
            }

                DBConnection.Shaitanet_420Entities.SaveChanges();
            MessageBox.Show("Данные успешно сохранены");
            NavigationService.Navigate(new FeedPage());
        }
    }
}
