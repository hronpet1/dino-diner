using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Base class for all Entrees
    /// </summary>
    public abstract class Entree : IMenuItem, IOrderItem, INotifyPropertyChanged
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
        /// Price of entree - provides get and set
        /// </summary>
        public virtual double Price { get; set; }
        /// <summary>
        /// Calories in entree - provides get and set
        /// </summary>
        public virtual uint Calories { get; set; }
        /// <summary>
        /// List of ingredients in entree - provides get
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
        public abstract string[] Special { get; }
    }
}
