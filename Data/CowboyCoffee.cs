using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Cowboy Coffee object to 
    /// represent the drink
    /// </summary>
    public class CowboyCoffee : Drink {

        /// <summary>
        /// If served with ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf { get; set; } = false;

        /// <summary>
        /// If room for cream is left
        /// </summary>
        public bool RoomForCream { get; set; } = false;

        /// <summary>
        /// Returns the correct calories based on the
        /// size of the selected drink
        /// </summary>
        public override uint Calories {
            get {
                switch (Size) {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
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
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
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
                if (Ice) instructions.Add("Add Ice");
                if (RoomForCream) instructions.Add("Room for Cream");
                return instructions;
            }
        }

        /// <summary>
        /// Makes the name of the drink more user friendly
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString() {
            return "Cowboy Coffee";
        }

    }
}
