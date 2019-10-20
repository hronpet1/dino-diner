using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// Base class for all Sides
    /// </summary>
    public abstract class Side : IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The PropertyChanged event handler notifies of changes to the Price, Description and Special properties
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void NotifyOfPropertyChange(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets the description of this order item
        /// </summary>
        public virtual string Description
        {
            get { return this.ToString(); }
        }
        /// <summary>
        /// Gets any special instructions for this order item
        /// </summary>
        public virtual string[] Special {
            get
            {
                List<string> special = new List<string>();
                return special.ToArray();
            }
        }
    

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }
        public string GetSizeString()
        {
            switch (Size)
            {
                case (Size.Small):
                    {
                        return "Small ";
                    }
                case (Size.Medium):
                    {
                        return "Medium ";
                    }
                case (Size.Large):
                    {
                        return "Large ";
                    }
            }
            return "";
        }
    }
}
