using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Jerked Soda object to
    /// represent the drink
    /// </summary>
    public class JerkedSoda : Drink {

        /// <summary>
        /// Stores the flavor of the drink
        /// </summary>
        SodaFlavor Flavor { get; set; }

        /// <summary>
        /// If served with ice
        /// </summary>
        public bool Ice { get; set; } = true;

        /// <summary>
        /// Returns the correct calories based on the
        /// size of the selected drink
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small:
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Returns the correct price of the drink based on 
        /// the selected size
        /// </summary>
        public override double Price {
            get {
                switch (Size) {
                    case Size.Small:
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// If any changes are made to how the drink is
        /// typically prepared
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                var instructions = new List<string>();
                if (!Ice) instructions.Add("hold ice");
                return instructions;
            }
        }

    }
}
