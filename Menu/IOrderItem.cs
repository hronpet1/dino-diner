﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for order item
    /// </summary>
    public interface IOrderItem : INotifyPropertyChanged
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
