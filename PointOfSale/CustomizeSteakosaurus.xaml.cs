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
using DinoDiner.Menu;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CustomizeSteakosaurus.xaml
    /// </summary>
    public partial class CustomizeSteakosaurus : Page
    {
        private SteakosaurusBurger Steakosaurus { get; set; }
        public CustomizeSteakosaurus(SteakosaurusBurger stea)
        {
            InitializeComponent();
            Steakosaurus = stea;
        }
        private void holdBun(object sender, RoutedEventArgs e)
        {
            this.Steakosaurus.HoldBun();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg00.Source = imageBitmap;
        }

        private void holdPickle(object sender, RoutedEventArgs e)
        {
            this.Steakosaurus.HoldPickle();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg10.Source = imageBitmap;
        }

        private void holdKetchup(object sender, RoutedEventArgs e)
        {
            this.Steakosaurus.HoldKetchup();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg20.Source = imageBitmap;
        }

        private void holdMustard(object sender, RoutedEventArgs e)
        {
            this.Steakosaurus.HoldMustard();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg01.Source = imageBitmap;
        }
    }
}
