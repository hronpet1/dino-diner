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
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {
        public static NavigationService NavigationService { get; set; }
        public OrderControl()
        {
            InitializeComponent();
        }

        public void OnCollectionChanged(object sender, EventArgs args)
        {
            CollectionViewSource.GetDefaultView(OrderItems.Items).MoveCurrentToLast();
        }
        private void OnSelectionChanged(object sender, SelectionChangedEventArgs args)
        {
            if (OrderItems.SelectedItem is Side side)
            {
                NavigationService?.Navigate(new SideSelection(side));
            }
            if (OrderItems.SelectedItem is Drink drink)
            {
                NavigationService?.Navigate(new DrinkSelection(drink));
            }
            if (OrderItems.SelectedItem is Entree entree)
            {
                NavigationService?.Navigate(new EntreeSelection(entree));
            }
        }

        public void OnDataContextChanged(object sender, DependencyPropertyChangedEventArgs args)
        {
            MountItemListener();
        }

        private void MountItemListener()
        {
            if(DataContext is Order order)
            {
                order.Items.CollectionChanged += OnCollectionChanged;
            }
        }
        
        private void OnRemoveOrder(object sender, RoutedEventArgs args)
        {
            if(DataContext is Order order)
            {
                MessageBoxResult res = MessageBox.Show("Are you sure you want to remove current order?", "Remove order", MessageBoxButton.OKCancel);
                if(res == MessageBoxResult.OK)
                {
                    order.Items.Clear();
                    NavigationService?.Navigate(new MenuCategorySelection());
                }               
            }
        }

        private void GoHome(object sender, RoutedEventArgs args)
        {
            NavigationService?.Navigate(new MenuCategorySelection());
        }
    
        private void RemoveItem(object sender, RoutedEventArgs args)
        {
            Button button = sender as Button;
            if (DataContext is Order order)
            {
                int index = order.Items.IndexOf((IOrderItem)button.DataContext);
                order.Items.RemoveAt(index);
            }
        }
    }
}
