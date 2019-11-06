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
    /// Interaction logic for CustomizeBrontowurst.xaml
    /// </summary>
    public partial class CustomizeBrontowurst : Page
    {
        private Brontowurst Bronto { get; set; }
        public CustomizeBrontowurst(Brontowurst bronto)
        {
            InitializeComponent();
            Bronto = bronto;
        }
        private void holdBun(object sender, RoutedEventArgs e)
        {
            this.Bronto.HoldBun();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg00.Source = imageBitmap;
        }

        private void holdOnions(object sender, RoutedEventArgs e)
        {
            this.Bronto.HoldOnion();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg10.Source = imageBitmap;
        }

        private void holdPeppers(object sender, RoutedEventArgs e)
        {
            this.Bronto.HoldPeppers();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg20.Source = imageBitmap;
        }
    }
}
