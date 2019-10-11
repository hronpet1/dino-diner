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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        /// <summary>
        /// Changes entree button based on chosen entree
        /// </summary>
        /// <param name="entree">Name of chosen entree</param>
        public CustomizeCombo(string entree)
        {
            InitializeComponent();
            switch (entree)
            {
                case "brontowurst":
                {
                        entreeName.Text = "Brontowurst";
                        Uri imageUri = new Uri("pack://application:,,,/images/wurst.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                }

                case "nuggets":
                    {
                        entreeName.Text = "Dino-nuggets";
                        Uri imageUri = new Uri("pack://application:,,,/images/nuggets.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
                case "pbj":
                    {
                        entreeName.Text = "Prehistoric PB&amp;J";
                        Uri imageUri = new Uri("pack://application:,,,/images/pbj.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
                case "steakosaurus":
                    {
                        entreeName.Text = "Steakosaurus";
                        Uri imageUri = new Uri("pack://application:,,,/images/steakosaurus.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
                case "trex":
                    {
                        entreeName.Text = "T-Rex King Burger";
                        Uri imageUri = new Uri("pack://application:,,,/images/trex.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
                case "wings":
                    {
                        entreeName.Text = "Pterodacyl Wings Combo";
                        Uri imageUri = new Uri("pack://application:,,,/images/wings.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
                case "wrap":
                    {
                        entreeName.Text = "Veloci-wrap";
                        Uri imageUri = new Uri("pack://application:,,,/images/wrap.png");
                        BitmapImage imageBitmap = new BitmapImage(imageUri);
                        entreeImage.Source = imageBitmap;
                        break;
                    }
            }
        }
        /// <summary>
        /// Opens new EntreeSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EntreeSelection());
        }
        /// <summary>
        /// Opens new SideSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection());
        }
        /// <summary>
        /// Opens new DrinkSelection windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection());
        }
    }
}
