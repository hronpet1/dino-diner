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
    /// Interaction logic for CustomizePBJ.xaml
    /// </summary>
    public partial class CustomizePBJ : Page
    {
        private PrehistoricPBJ PBJ{ get; set; }
        public CustomizePBJ(PrehistoricPBJ pbj)
        {
            InitializeComponent();
            PBJ = pbj;
        }
        private void holdJelly(object sender, RoutedEventArgs e)
        {
            this.PBJ.HoldJelly();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg00.Source = imageBitmap;
        }

        private void holdPeanutButter(object sender, RoutedEventArgs e)
        {
            this.PBJ.HoldPeanutButter();
            Uri imageUri = new Uri("pack://application:,,,/images/cross.png");
            BitmapImage imageBitmap = new BitmapImage(imageUri);
            btnImg10.Source = imageBitmap;
        }

    }
}
