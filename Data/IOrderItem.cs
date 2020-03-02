using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {
    public class IOrderItem {
        /// <summary>
        /// The price of an ordered item
        /// </summary>
        public virtual double Price { get; set; }

        /// <summary>
        /// The special instructions for an ordered item
        /// </summary>
        public virtual List<string> SpecialInstructions { get; set; }
    }
}
