using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for order item
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// Price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// Description of the item 
        /// </summary>
        string Description { get; }

        /// <summary>
        /// Special instructions for preparation of the item
        /// </summary>
        string[] Special { get; }
    }
}
