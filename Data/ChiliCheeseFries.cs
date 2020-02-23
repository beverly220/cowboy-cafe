using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Chili Cheese Fries object to represent the side
    /// </summary>
    public class ChiliCheeseFries : Side {

        /// <summary>
        /// Returns the correct calories based on the
        /// size of the selected side
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small:
                        return 433;
                    case Size.Medium:
                        return 524;
                    case Size.Large:
                        return 610;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the correct price of the side based on 
        /// the selected size
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small:
                        return 1.99;
                    case Size.Medium:
                        return 2.99;
                    case Size.Large:
                        return 3.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Makes the name of the side more user friendly
        /// </summary>
        /// <returns>The name of the side</returns>
        public override string ToString() {
            return "Chili Cheese Fries";
        }

    }
}
