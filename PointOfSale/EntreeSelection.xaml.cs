﻿using DinoDiner.Menu;
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
                order.Add(entree);
                this.Entree = entree;
            }
        }

        /// <summary>
        /// Adds new Brontowurst to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWurst(object sender, RoutedEventArgs e)
        {
            SelectEntree(new Brontowurst());
            NavigationService.Navigate(new CustomizeBrontowurst((Brontowurst)Entree));
        }
        /// <summary>
        /// Adds new PrehistoricPBJ to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddPBJ(object sender, RoutedEventArgs e)
        {
            SelectEntree(new PrehistoricPBJ());
            NavigationService.Navigate(new CustomizePBJ((PrehistoricPBJ)Entree));
        }
        /// <summary>
        /// Adds new VelociWrap to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddWrap(object sender, RoutedEventArgs e)
        {
            SelectEntree(new VelociWrap());
            NavigationService.Navigate(new CustomizeWrap((VelociWrap)Entree));
        }
        /// <summary>
        /// Adds new DinoNuggets to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddNuggets(object sender, RoutedEventArgs e)
        {
            SelectEntree(new DinoNuggets());
            NavigationService.Navigate(new CustomizeNuggets((DinoNuggets)Entree));
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
            NavigationService.Navigate(new CustomizeSteakosaurus((SteakosaurusBurger)Entree));
        }
        /// <summary>
        /// Adds new TRexKingBurger to the Order
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AddTrex(object sender, RoutedEventArgs e)
        {
            SelectEntree(new TRexKingBurger());
            NavigationService.Navigate(new CustomizeTRex((TRexKingBurger)Entree));
        }
    }
}
