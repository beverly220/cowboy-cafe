using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem {

        /// <summary>
        /// Gets the calories of each entree
        /// </summary>
        public abstract uint Calories { get; }

    }
}
