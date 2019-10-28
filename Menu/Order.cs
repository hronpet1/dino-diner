using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Text;
using DinoDiner.Menu;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class representing customer order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// List of ordered items
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; protected set;}

        /// <summary>
        /// Price of all items in order without tax
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double subtotal = 0;
                foreach (IOrderItem orderItem in Items)
                {
                    subtotal += orderItem.Price;
                }
                if (subtotal < 0)
                    return 0;
                else
                    return subtotal;
            }
        }
        /// <summary>
        /// Tax rate
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0;

        /// <summary>
        /// Calculated tax cost based on SalesTaxRate and SubtotalCost
        /// </summary>
        public double SalesTaxCost
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// Final cost of order - Subtotal and SalesTax
        /// </summary>
        public double TotalCost
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
        public Order()
        {
            Items = new ObservableCollection<IOrderItem>();
            Items.CollectionChanged += OnCollectionChanged;
        }
        /// <summary>
        /// Updates costs for each change of the Items collection
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotalcost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Totalcost"));
            if (args.Action == NotifyCollectionChangedAction.Remove)
            {
                foreach (IOrderItem item in args.OldItems)
                {
                    //Removed items
                    item.PropertyChanged -= EntityViewModelPropertyChanged;
                }
            }
            else if (args.Action == NotifyCollectionChangedAction.Add)
            {
                foreach (IOrderItem item in args.NewItems)
                {
                    //Added items
                    item.PropertyChanged += EntityViewModelPropertyChanged;
                }
            }
        }

        public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        {

            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotalcost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Totalcost"));
        }
        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
