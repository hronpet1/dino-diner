using DinoDiner.Menu;
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
    /// Interaction logic for SideSelection.xaml
    /// </summary>
    public partial class SideSelection : Page
    {
        public Side Side { get; set; }
        public SideSelection()
        {
            InitializeComponent();
        }

        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(side);
                this.Side = side;
            }
        }
        protected void AddFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }

        private void AddMezzorelaSticks(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());

        }

        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());

        }

        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());

        }

        private void SizeButton(object sender, RoutedEventArgs e)
        {
            DinoDiner.Menu.Size size = DinoDiner.Menu.Size.Small;
            OnSizeSelect(size);
        }
        protected void OnSizeSelect(DinoDiner.Menu.Size size)
        {
            switch (size)
            {
                case (DinoDiner.Menu.Size.Small):
                    break;
                case (DinoDiner.Menu.Size.Medium):
                    break;
                case (DinoDiner.Menu.Size.Large):
                    break;
            }
        }
    }
}
