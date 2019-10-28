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

        private void SmallButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Small);
        }

        private void MediumButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }

        private void LargeButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }

        private void SetSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
                Side.Size = size;
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
