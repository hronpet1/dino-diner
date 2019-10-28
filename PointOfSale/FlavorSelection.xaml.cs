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
    /// Interaction logic for FlavorSelection.xaml
    /// </summary>
    public partial class FlavorSelection : Page
    {
        Sodasaurus Soda { get; set; }
        public FlavorSelection(Sodasaurus soda)
        {
            InitializeComponent();
            Soda = soda;
        }
        /// <summary>
        /// Changes flavor of the Soda to Cola and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ColaClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Cola;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to Chocolate and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChocoClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Chocolate;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to Vanilla and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void VanillaClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Vanilla;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to Orange and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OrangeClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Orange;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to Lime and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LimeClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Lime;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to RootBeer and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RootBeerClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.RootBeer;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }
        /// <summary>
        /// Changes flavor of the Soda to Cherry and navigates back to DrinkSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CherryClick(object sender, RoutedEventArgs e)
        {
            Soda.Flavor = SodasaurusFlavor.Cherry;
            NavigationService.Navigate(new DrinkSelection(Soda));
        }

    }
}
