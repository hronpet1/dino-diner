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
    /// Interaction logic for MenuCategorySelection.xaml
    /// </summary>
    public partial class MenuCategorySelection : Page
    {
        public MenuCategorySelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens new ComboSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectCombo(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ComboSelection());
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
