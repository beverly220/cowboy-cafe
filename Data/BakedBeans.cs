using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Baked Beans object to represent the side
    /// </summary>
    public class BakedBeans : Side {

        /// <summary>
        /// Returns the correct calories based on the
        /// size of the selected side
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small:
                        return 312;
                    case Size.Medium:
                        return 378;
                    case Size.Large:
                        return 410;
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
                        return 1.59;
                    case Size.Medium:
                        return 1.79;
                    case Size.Large:
                        return 1.99;
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
            switch (Size) {
                case Size.Small:
                    return "Small Baked Beans";
                case Size.Medium:
                    return "Medium Baked Beans";
                case Size.Large:
                    return "Large Baked Beans";
                default:
                    throw new NotImplementedException();   
            }
        }

    }
}
