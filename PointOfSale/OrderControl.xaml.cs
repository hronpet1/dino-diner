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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public static NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }
        /// <summary>
        /// Called when new Item from the Order is selected and navigates to the correct window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is CretaceousCombo combo)
            {
                NavigationService?.Navigate(new CustomizeCombo(combo));
            }
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            if (OrderItems.SelectedItem is Entree entree)
            {
                if (entree is Brontowurst)
                {
                    NavigationService.Navigate(new CustomizeBrontowurst((Brontowurst)entree));
                }
                else if (entree is PrehistoricPBJ)
                {
                    NavigationService.Navigate(new CustomizePBJ((PrehistoricPBJ)entree));
                }
                else if (entree is VelociWrap)
                {
                    NavigationService.Navigate(new CustomizeWrap((VelociWrap)entree));
                }
                else if (entree is DinoNuggets)
                {
                    NavigationService.Navigate(new CustomizeNuggets((DinoNuggets)entree));
                }
                else if (entree is SteakosaurusBurger)
                {
                    NavigationService.Navigate(new CustomizeSteakosaurus((SteakosaurusBurger)entree));
                }
                else if (entree is TRexKingBurger)
                {
                    NavigationService.Navigate(new CustomizeTRex((TRexKingBurger)entree));
                }
                else
                {
                    return;
                }
            }
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }

        private void MountItemListener()
        {
            if(DataContext is Order order)
            {
                //order.Items.CollectionChanged += OnCollectionChanged;
            }
        }
        /// <summary>
        /// Asks for confirmation from user and if confirmed, deletes all items from current Order and returns to the MenuCategorySelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnRemoveOrder(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                MessageBoxResult res = MessageBox.Show("Are you sure you want to remove current order?", "Remove order", MessageBoxButton.OKCancel);
                if(res == MessageBoxResult.OK)
                {
                    order.Clear();
                    NavigationService?.Navigate(new MenuCategorySelection());
                }               
            }
        }
        /// <summary>
        /// Returns user to the MenuCategorySelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void GoHome(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }
    
        /// <summary>
        /// Removes Item from Order, whose Delete button was clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            Button button = sender as Button;
            if (DataContext is Order order)
            {
                // int index = order.Items.IndexOf((IOrderItem)button.DataContext);
                // order.RemoveAt(index);
                order.Remove((IOrderItem)button.DataContext);
            }
        }
    }
}
