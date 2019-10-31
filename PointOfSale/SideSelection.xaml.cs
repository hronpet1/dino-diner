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
        /// <summary>
        /// Currently edited Side
        /// </summary>
        public Side Side { get; set; }
        public SideSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Called when editing existing Side from Order
        /// </summary>
        /// <param name="side"></param>
        public SideSelection(Side side)
        {
            InitializeComponent();
            Side = side;
        }
        /// <summary>
        /// Adds new Side to the Order 
        /// </summary>
        /// <param name="side">Side to be added to Order</param>
        private void SelectSide(Side side)
        {
            if (DataContext is Order order)
            {
                order.Add(side);
                this.Side = side;
            }
        }
        /// <summary>
        /// Adds new Fryceritops to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        protected void AddFryceritops(object sender, RoutedEventArgs e)
        {
            SelectSide(new Fryceritops());
        }
        /// <summary>
        /// Adds new MezzorellaSticks to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMezzorelaSticks(object sender, RoutedEventArgs e)
        {
            SelectSide(new MezzorellaSticks());

        }
        /// <summary>
        /// Adds new MeteorMacAndCheese to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddMeteorMacAndCheese(object sender, RoutedEventArgs e)
        {
            SelectSide(new MeteorMacAndCheese());

        }
        /// <summary>
        /// Adds new Triceritots to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTriceritots(object sender, RoutedEventArgs e)
        {
            SelectSide(new Triceritots());

        }
        /// <summary>
        /// Changes Size of SelectedItem to Small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Small);
        }
        /// <summary>
        /// Changes Size of SelectedItem to Medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }
        /// <summary>
        /// Changes Size of SelectedItem to Large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }
        /// <summary>
        /// Sets size of currently selected Side
        /// </summary>
        /// <param name="size">New Size of the Side</param>
        private void SetSize(DinoDiner.Menu.Size size)
        {
            if (Side != null)
                Side.Size = size;
            NavigationService.Navigate(new MenuCategorySelection());
        }
    }
}
