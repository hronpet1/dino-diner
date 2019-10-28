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
    /// Interaction logic for EntreeSelection.xaml
    /// </summary>
    public partial class EntreeSelection : Page
    {
        /// <summary>
        /// Currently edited Entree
        /// </summary>
        Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Called when editing existing Entree
        /// </summary>
        /// <param name="entree"></param>
        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        /// <summary>
        /// Adds new Entree to the Order
        /// </summary>
        /// <param name="entree">Entree to be added</param>
        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        /// <summary>
        /// Adds new Brontowurst to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWurst(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
        }
        /// <summary>
        /// Adds new PrehistoricPBJ to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPBJ(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PrehistoricPBJ());
        }
        /// <summary>
        /// Adds new VelociWrap to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWrap(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
        }
        /// <summary>
        /// Adds new DinoNuggets to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNuggets(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
        }
        /// <summary>
        /// Adds new PterodactylWings to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWings(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
        }
        /// <summary>
        /// Adds new SteakosaurusBurger to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddSteakosaurus(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());
        }
        /// <summary>
        /// Adds new TRexKingBurger to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrex(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
        }
    }
}
