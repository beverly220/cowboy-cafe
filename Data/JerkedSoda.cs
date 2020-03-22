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
        /// Defaults the Jerked Soda to have flavor
        /// </summary>
        private SodaFlavor flavor;

        /// <summary>
        /// Stores the flavor of the drink
        /// </summary>
        public SodaFlavor Flavor {
            get {
                return flavor;
            }
            set {
                flavor = value;
                NotifyOfPropertyChanged("Flavor");
            }
        }

        /// <summary>
        /// Defaults the Jerked Soda to have ice
        /// </summary>
        private bool ice = true;

        /// <summary>
        /// If served with ice
        /// </summary>
        public override bool Ice { 
            get {
                return ice;
            }
            set {
                ice = value;
                NotifyOfPropertyChanged("Ice");
            }
        }

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
                if (!Ice) instructions.Add("Hold Ice");
                return instructions;
            }
        }

        /// <summary>
        /// Makes the name of the drink more user friendly
        /// </summary>
        /// <returns>The name of the drink</returns>
        public override string ToString() {
            switch (Flavor) {
                case SodaFlavor.CreamSoda:
                    switch (Size) {
                        case Size.Small:
                            return "Small Cream Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Cream Soda Jerked Soda";
                        case Size.Large:
                            return "Large Cream Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.BirchBeer:
                    switch (Size) {
                        case Size.Small:
                            return "Small Birch Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Birch Beer Jerked Soda";
                        case Size.Large:
                            return "Large Birch Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.OrangeSoda:
                    switch (Size) {
                        case Size.Small:
                            return "Small Orange Soda Jerked Soda";
                        case Size.Medium:
                            return "Medium Orange Soda Jerked Soda";
                        case Size.Large:
                            return "Large Orange Soda Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.RootBeer:
                    switch (Size) {
                        case Size.Small:
                            return "Small Root Beer Jerked Soda";
                        case Size.Medium:
                            return "Medium Root Beer Jerked Soda";
                        case Size.Large:
                            return "Large Root Beer Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                case SodaFlavor.Sarsparilla:
                    switch (Size) {
                        case Size.Small:
                            return "Small Sarsparilla Jerked Soda";
                        case Size.Medium:
                            return "Medium Sarsparilla Jerked Soda";
                        case Size.Large:
                            return "Large Sarsparilla Jerked Soda";
                        default:
                            throw new NotImplementedException();
                    }
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
