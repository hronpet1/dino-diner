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
    /// Interaction logic for DrinkSelection.xaml
    /// </summary>
    public partial class DrinkSelection : Page
    {
        Drink Drink { get; set; }
        public DrinkSelection()
        {
            InitializeComponent();
        }
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            if (drink is Sodasaurus)
            {
                lemon.Visibility = Visibility.Collapsed;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Visible;
                holdice.Content = "Hold Ice";
            }
            else if (drink is Tyrannotea)
            {
                lemon.Visibility = Visibility.Visible;
                sugar.Visibility = Visibility.Visible;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Collapsed;
                holdice.Content = "Hold Ice";
            }
            else if (drink is Water)
            {
                lemon.Visibility = Visibility.Visible;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Collapsed;
                holdice.Content = "Hold Ice";
            }
            else if (drink is JurassicJava)
            {
                lemon.Visibility = Visibility.Collapsed;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Visible;
                cream.Visibility = Visibility.Visible;
                flavor.Visibility = Visibility.Collapsed;
                holdice.Content = "Add Ice";
            }
            else
            {

            }
        }
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(drink);
                this.Drink = drink;
            }
        }
        /// <summary>
        /// Opens new FlavorSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }
        /// <summary>
        /// Shows FlavorChoose button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusClick(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Sodasaurus());
        }
        /// <summary>
        /// Shows AddLemon button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Water());
        }
        /// <summary>
        /// Shows AddSugar button and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaClick(object sender, RoutedEventArgs e)
        {
            SelectDrink(new Tyrannotea());
        }
        /// <summary>
        /// Shows Decaf and AddCream buttons and hides others
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaClick(object sender, RoutedEventArgs e)
        {
            SelectDrink(new JurassicJava());
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
            if (Drink != null)
                Drink.Size = size;
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void AddLemon(object sender, RoutedEventArgs e)
        {
            if (Drink is Tyrannotea tyrannotea)
                tyrannotea.AddLemon();
            if (Drink is Water water)
                water.AddLemon();
        }

        private void AddSugar(object sender, RoutedEventArgs e)
        {
            if (Drink is Tyrannotea tyrannotea)
                tyrannotea.AddSweet();
        }

        private void Decaf(object sender, RoutedEventArgs e)
        {
            if (Drink is JurassicJava java)
                java.AddDecaf();
        }

        private void LeaveRoomForCream(object sender, RoutedEventArgs e)
        {
            if (Drink is JurassicJava java)
                java.LeaveRoomForCream();
        }
        private void HoldIce(object sender, RoutedEventArgs e)
        {
            if (Drink is JurassicJava java)
                java.AddIce();
            else
                Drink.HoldIce();
        }
    }
}
