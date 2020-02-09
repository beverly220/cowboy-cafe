using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree {

        /// <summary>
        /// Gets the price of each entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of each entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets a list of special instructions for
        /// each entree that shows any changes made
        /// from the original entree
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
