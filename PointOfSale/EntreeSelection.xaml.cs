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
        Entree Entree { get; set; }
        public EntreeSelection()
        {
            InitializeComponent();
        }

        public EntreeSelection(Entree entree)
        {
            InitializeComponent();
            Entree = entree;
        }

        private void SelectEntree(Entree entree)
        {
            if (DataContext is Order order)
            {
                order.Items.Add(entree);
                this.Entree = entree;
            }
            NavigationService.Navigate(new MenuCategorySelection());
        }

        private void AddWurst(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
        }
        private void AddPBJ(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PrehistoricPBJ());
        }
        private void AddWrap(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
        }
        private void AddNuggets(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
        }
        private void AddWings(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PterodactylWings());
        }
        private void AddSteakosaurus(object sender, RoutedEventArgs e)
        {
            SelectEntree(new SteakosaurusBurger());
        }
        private void AddTrex(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
        }
    }
}
