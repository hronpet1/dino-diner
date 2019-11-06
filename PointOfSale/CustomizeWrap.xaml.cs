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
    /// Interaction logic for CustomizeWrap.xaml
    /// </summary>
    public partial class CustomizeWrap : Page
    {
        private VelociWrap Wrap { get; set; }
        public CustomizeWrap(VelociWrap wrap)
        {
            InitializeComponent();
            Wrap = wrap;
        }
        private void holdDressing(object sender, RoutedEventArgs e)
        {
            this.Wrap.HoldDressing();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg00.Source = imageBitmap;
        }

        private void holdLettuce(object sender, RoutedEventArgs e)
        {
            this.Wrap.HoldLettuce();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg10.Source = imageBitmap;
        }

        private void holdCheese(object sender, RoutedEventArgs e)
        {
            this.Wrap.HoldCheese();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg20.Source = imageBitmap;
        }
    }
}
