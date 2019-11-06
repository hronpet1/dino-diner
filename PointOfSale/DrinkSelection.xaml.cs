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
        /// <summary>
        /// Currently edited Drink
        /// </summary>
        Drink Drink { get; set; } = null;
        CretaceousCombo Combo { get; set; } = null;
        public DrinkSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Called when editing existing Entree, shows only relevant buttons
        /// </summary>
        /// <param name="entree"></param>
        public DrinkSelection(Drink drink)
        {
            InitializeComponent();
            Drink = drink;
            SetButtons(Drink);
        }

        public DrinkSelection(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            SetButtons(Combo.Drink);
        }
        private void SetButtons(Drink Drink)
        {
            if (Drink is Sodasaurus)
            {
                lemon.Visibility = Visibility.Collapsed;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Visible;
                holdIceText.Text = "Hold \nIce";
            }
            else if (Drink is Tyrannotea)
            {
                lemon.Visibility = Visibility.Visible;
                sugar.Visibility = Visibility.Visible;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Collapsed;
                holdIceText.Text = "Hold \nIce";
            }
            else if (Drink is Water)
            {
                lemon.Visibility = Visibility.Visible;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Collapsed;
                cream.Visibility = Visibility.Collapsed;
                flavor.Visibility = Visibility.Collapsed;
                holdIceText.Text = "Hold \nIce";
            }
            else if (Drink is JurassicJava)
            {
                lemon.Visibility = Visibility.Collapsed;
                sugar.Visibility = Visibility.Collapsed;
                decaf.Visibility = Visibility.Visible;
                cream.Visibility = Visibility.Visible;
                flavor.Visibility = Visibility.Collapsed;
                holdIceText.Text = "Add \nIce";
            }
        }
        /// <summary>
        /// Adds new Drink to the Order
        /// </summary>
        /// <param name="drink">Drink to be added</param>
        private void SelectDrink(Drink drink)
        {
            if (DataContext is Order order)
            {
                if(Combo != null)
                {
                    Combo.Drink = drink;
                    SetButtons(Combo.Drink);

                }
                else
                {
                    order.Add(drink);
                    this.Drink = drink;
                    SetButtons(Drink);

                }
            }
        }
        /// <summary>
        /// Opens new FlavorSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void ChooseFlavor(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)Combo.Drink));
            else
                NavigationService.Navigate(new FlavorSelection((Sodasaurus)Drink));
        }
        /// <summary>
        /// Shows FlavorChoose button and hides others, adds new Sodasaurus
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SodasaurusClick(object sender, RoutedEventArgs e)
        {
                SelectDrink(new Sodasaurus());
        }
        /// <summary>
        /// Shows AddLemon button and hides others, adds new Water
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void WaterClick(object sender, RoutedEventArgs e)
        {
                SelectDrink(new Water());
        }
        /// <summary>
        /// Shows AddSugar button and hides others, adds new Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void TyrannoteaClick(object sender, RoutedEventArgs e)
        {
               SelectDrink(new Tyrannotea());
        }
        /// <summary>
        /// Shows Decaf and AddCream buttons and hides others, adds new JurrasicJava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void JurassicJavaClick(object sender, RoutedEventArgs e)
        {
            SelectDrink(new JurassicJava());
        }

        /// <summary>
        /// Changes Size of selected Drink to Small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Small);
        }
        /// <summary>
        /// Changes Size of selected Drink to Small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Medium);
        }
        /// <summary>
        /// Changes Size of selected Drink to Small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeButton(object sender, RoutedEventArgs e)
        {
            SetSize(DinoDiner.Menu.Size.Large);
        }

        /// <summary>
        /// Sets Size of selected Drink and returns to MenuCategorySelection window
        /// </summary>
        /// <param name="size">New size of the selected Drink</param>
        private void SetSize(DinoDiner.Menu.Size size)
        {
            if (Combo != null)
                Combo.Drink.Size = size;
            else if (Drink != null)
                Drink.Size = size;
        }
        /// <summary>
        /// Calls AddLemon function for selected Water or Tyrannotea 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddLemon(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
            {
                if (Combo.Drink is Tyrannotea tyrannotea)
                    tyrannotea.AddLemon();
                if (Combo.Drink is Water water)
                    water.AddLemon();
            }
            else
            {
                if (Drink is Tyrannotea tyrannotea)
                    tyrannotea.AddLemon();
                if (Drink is Water water)
                    water.AddLemon();
            }
        }
        /// <summary>
        /// Calls AddSugar function for selected Tyrannotea
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSugar(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
            {
                if (Combo.Drink is Tyrannotea tyrannotea)
                    tyrannotea.AddSweet();
            }
            else
            {
                if (Drink is Tyrannotea tyrannotea)
                    tyrannotea.AddSweet();
            }
        }
        /// <summary>
        /// Calls AddDecaf function for selected JurassicJava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Decaf(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
            {
                if (Combo.Drink is JurassicJava java)
                    java.AddDecaf();
            }
            else
            {
                if (Drink is JurassicJava java)
                    java.AddDecaf();
            }
        }
        /// <summary>
        /// Calls LeaveRoomForCream function for selected JurassicJava
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LeaveRoomForCream(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
            {
                if (Combo.Drink is JurassicJava java)
                    java.LeaveRoomForCream();
            }
            else
            {
                if (Drink is JurassicJava java)
                    java.LeaveRoomForCream();
            }
        }
        /// <summary>
        /// Calls AddIce / HoldIce function for selected Drink, based on type
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void HoldIce(object sender, RoutedEventArgs e)
        {
            if(Combo != null)
            {
                if (Combo.Drink is JurassicJava java)
                    java.AddIce();
                else
                    Combo.Drink.HoldIce();
            }
            else
            {
                if (Drink is JurassicJava java)
                    java.AddIce();
                else
                    Drink.HoldIce();
            }
        }
    }
}
