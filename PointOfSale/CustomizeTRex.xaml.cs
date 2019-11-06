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
    /// Interaction logic for CustomizeTRex.xaml
    /// </summary>
    public partial class CustomizeTRex : Page
    {
        private TRexKingBurger TRex { get; set; }
        public CustomizeTRex(TRexKingBurger trex)
        {
            InitializeComponent();
            TRex = trex;
        }
        private void holdBun(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldBun();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg00.Source = imageBitmap;
        }

        private void holdLettuce(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldLettuce();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg10.Source = imageBitmap;
        }

        private void holdTomato(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldTomato();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg20.Source = imageBitmap;
        }

        private void holdMayo(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldMayo();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg01.Source = imageBitmap;
        }


        private void holdPickle(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldPickle();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg11.Source = imageBitmap;
        }

        private void holdKetchup(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldKetchup();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg21.Source = imageBitmap;
        }

        private void holdMustard(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldMustard();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg02.Source = imageBitmap;
        }

        private void holdOnion(object sender, RoutedEventArgs e)
        {
            this.TRex.HoldOnion();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg12.Source = imageBitmap;
        }
    }
}
