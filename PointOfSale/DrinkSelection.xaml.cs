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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens new FlavorSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection());
        }
        /// <summary>
        /// Shows FlavorChoose button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusClick(object sender, RoutedEventArgs e)
        {
            lemon.Visibility = Visibility.Collapsed;
            sugar.Visibility = Visibility.Collapsed;
            decaf.Visibility = Visibility.Collapsed;
            cream.Visibility = Visibility.Collapsed;
            flavor.Visibility = Visibility.Visible;
        }
        /// <summary>
        /// Shows AddLemon button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            lemon.Visibility = Visibility.Visible;
            sugar.Visibility = Visibility.Collapsed;
            decaf.Visibility = Visibility.Collapsed;
            cream.Visibility = Visibility.Collapsed;
            flavor.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Shows AddSugar button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaClick(object sender, RoutedEventArgs e)
        {
            lemon.Visibility = Visibility.Collapsed;
            sugar.Visibility = Visibility.Visible;
            decaf.Visibility = Visibility.Collapsed;
            cream.Visibility = Visibility.Collapsed;
            flavor.Visibility = Visibility.Collapsed;
        }
        /// <summary>
        /// Shows Decaf and AddCream buttons and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaClick(object sender, RoutedEventArgs e)
        {
            lemon.Visibility = Visibility.Collapsed;
            sugar.Visibility = Visibility.Collapsed;
            decaf.Visibility = Visibility.Visible;
            cream.Visibility = Visibility.Visible;
            flavor.Visibility = Visibility.Collapsed;
        }
    }
}
