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
    /// Interaction logic for ComboSelection.xaml
    /// </summary>
    public partial class ComboSelection : Page
    {
        public ComboSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Opens new CustomizeCombo and sends choice as parameter
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CustomizeCombo(object sender, RoutedEventArgs e)
        {
            var button = (Button)sender;
            CretaceousCombo Combo;
            switch (button.Name)
            {
                case "brontowurst":
                    {
                        Combo = new CretaceousCombo(new Brontowurst());
                        break;
                    }

                case "nuggets":
                    {
                        Combo = new CretaceousCombo(new DinoNuggets());
                        break;
                    }
                case "pbj":
                    {
                        Combo = new CretaceousCombo(new PrehistoricPBJ());
                        break;
                    }
                case "steakosaurus":
                    {
                        Combo = new CretaceousCombo(new SteakosaurusBurger());
                        break;
                    }
                case "trex":
                    {
                        Combo = new CretaceousCombo(new TRexKingBurger());
                        break;
                    }
                case "wings":
                    {
                        Combo = new CretaceousCombo(new PterodactylWings());
                        break;
                    }
                case "wrap":
                    {
                        Combo = new CretaceousCombo(new VelociWrap());
                        break;
                    }
                default:
                    {
                        Combo = new CretaceousCombo(new Brontowurst());
                        break;
                    }
            }
            if (DataContext is Order order)
            {
                order.Add(Combo);
            }
            NavigationService.Navigate(new CustomizeCombo(Combo));
        }
    }
}
