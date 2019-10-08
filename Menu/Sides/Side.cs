using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu 
{
    /// <summary>
    /// Base class for all Sides
    /// </summary>
    public abstract class Side : IMenuItem
    {
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
