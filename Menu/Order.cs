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
        // Backing variables
        private double salesTaxRate = 0;
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// List of ordered items
        /// </summary>
        public IOrderItem[] Items {
            get
            {
                return items.ToArray();
            }
        }

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
        public double SalesTaxRate { get
            {
                return salesTaxRate;
            }
            protected set
            {
                salesTaxRate = value;
            }
        }

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
        }
        /// <summary>
        /// An event handler for property changes
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Add a new item to our order
        /// </summary>
        /// <param name="item"></param>
        public void Add(IOrderItem item)
        {
            items.Add(item);
            item.PropertyChanged += OnPropertyChanged;
            Notify();
        }

        public bool Remove(IOrderItem item)
        {
            bool removed = items.Remove(item);
            if (removed) Notify();
            return removed;
        }

        public void Clear()
        {
            items.Clear();
            Notify();
        }
        private void OnPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            Notify();
        }

        private void Notify()
        {
            NotifyOfPropertyChanged("Items");
            NotifyOfPropertyChanged("Subtotalcost");
            NotifyOfPropertyChanged("SalesTaxCost");
            NotifyOfPropertyChanged("Totalcost");
        }

        private void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
