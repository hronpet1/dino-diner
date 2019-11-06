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
    /// Interaction logic for CustomizeCombo.xaml
    /// </summary>
    public partial class CustomizeCombo : Page
    {
        private CretaceousCombo Combo { get; set; }
        /// <summary>
        /// Changes entree button based on chosen entree
        /// </summary>
        /// <param name="entree">Name of chosen entree</param>
        public CustomizeCombo(CretaceousCombo combo)
        {
            InitializeComponent();
            Combo = combo;
            if (Combo.Entree is Brontowurst)
            {
                entreeName.Text = "Brontowurst";
                Uri imageUri = new Uri("pack://application:,,,/images/wurst.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is PrehistoricPBJ)
            {
                entreeName.Text = "Prehistoric PB&amp;J";
                Uri imageUri = new Uri("pack://application:,,,/images/pbj.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is VelociWrap)
            {
                entreeName.Text = "Veloci-wrap";
                Uri imageUri = new Uri("pack://application:,,,/images/wrap.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is DinoNuggets)
            {
                entreeName.Text = "Dino-nuggets";
                Uri imageUri = new Uri("pack://application:,,,/images/nuggets.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is SteakosaurusBurger)
            {
                entreeName.Text = "Steakosaurus";
                Uri imageUri = new Uri("pack://application:,,,/images/steakosaurus.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is TRexKingBurger)
            {
                entreeName.Text = "T-Rex King Burger";
                Uri imageUri = new Uri("pack://application:,,,/images/trex.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            else if (Combo.Entree is PterodactylWings)
            {
                entreeName.Text = "Pterodacyl Wings Combo";
                Uri imageUri = new Uri("pack://application:,,,/images/wings.png");
                BitmapImage imageBitmap = new BitmapImage(imageUri);
                entreeImage.Source = imageBitmap;
            }
            
        }
        /// <summary>
        /// Opens new EntreeSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectEntree(object sender, RoutedEventArgs e)
        {

            if (Combo.Entree is Brontowurst)
            {
                NavigationService.Navigate(new CustomizeBrontowurst((Brontowurst)Combo.Entree));
            }
            else if (Combo.Entree is PrehistoricPBJ)
            {
                NavigationService.Navigate(new CustomizePBJ((PrehistoricPBJ)Combo.Entree));
            }
            else if (Combo.Entree is VelociWrap)
            {
                NavigationService.Navigate(new CustomizeWrap((VelociWrap)Combo.Entree));
            }
            else if (Combo.Entree is DinoNuggets)
            {
                NavigationService.Navigate(new CustomizeNuggets((DinoNuggets)Combo.Entree));
            }
            else if (Combo.Entree is SteakosaurusBurger)
            {
                NavigationService.Navigate(new CustomizeSteakosaurus((SteakosaurusBurger)Combo.Entree));
            }
            else if (Combo.Entree is TRexKingBurger)
            {
                NavigationService.Navigate(new CustomizeTRex((TRexKingBurger)Combo.Entree));
            }
            else
            {
                return;
            }
        }
        /// <summary>
        /// Opens new SideSelection window
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectSide(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new SideSelection(Combo));
        }
        /// <summary>
        /// Opens new DrinkSelection windows
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SelectDrink(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new DrinkSelection(Combo));
        }
        /// <summary>
        /// Change size of side and drink to small
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SmallButton(object sender, RoutedEventArgs e)
        {
            Combo.Side.Size = DinoDiner.Menu.Size.Small;
            Combo.Drink.Size = DinoDiner.Menu.Size.Small;
        }
        /// <summary>
        /// Change size of side and drink to medium
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void MediumButton(object sender, RoutedEventArgs e)
        {
            Combo.Side.Size = DinoDiner.Menu.Size.Medium;
            Combo.Drink.Size = DinoDiner.Menu.Size.Medium;
        }
        /// <summary>
        /// Change size of side and drink to large
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LargeButton(object sender, RoutedEventArgs e)
        {
            Combo.Side.Size = DinoDiner.Menu.Size.Large;
            Combo.Drink.Size = DinoDiner.Menu.Size.Large;
        }
    }
}
