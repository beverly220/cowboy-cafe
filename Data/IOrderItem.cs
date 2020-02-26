using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {
    public class IOrderItem {
        /// <summary>
        /// The price of an ordered item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The special instructions for an ordered item
        /// </summary>
        List<string> SpecialInstructions { get; }
    }
}
