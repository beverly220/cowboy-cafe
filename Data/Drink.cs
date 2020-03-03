using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem  {

        /// <summary>
        /// Gets the calories of each drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        /// <summary>
        /// If the drink comes with ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;
    }




}

