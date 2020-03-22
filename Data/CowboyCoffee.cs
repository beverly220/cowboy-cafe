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
        /// Defaults the Cowboy Coffee to not have ice
        /// </summary>
        private bool ice = false;

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
        /// Defaults the Cowboy Coffee to not be decaf
        /// </summary>
        private bool decaf = false;

        /// <summary>
        /// If the coffee is decaf
        /// </summary>
        public bool Decaf {
            get {
                return decaf;
            }
            set {
                decaf = value;
                NotifyOfPropertyChanged("Decaf");
            }
        }

        /// <summary>
        /// Defaults the Cowboy Coffee to not have
        /// room for cream
        /// </summary>
        private bool roomForCream = false;

        /// <summary>
        /// If room for cream is left
        /// </summary>
        public bool RoomForCream {
            get {
                return roomForCream;
            }
            set {
                roomForCream = value;
                NotifyOfPropertyChanged("RoomForCream");
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
            switch (Size) {
                case Size.Small:
                    if(Decaf) {
                        return "Small Decaf Cowboy Coffee";
                    }
                    return "Small Cowboy Coffee";
                case Size.Medium:
                    if (Decaf) {
                        return "Medium Decaf Cowboy Coffee";
                    }
                    return "Medium Cowboy Coffee";
                case Size.Large:
                    if (Decaf) {
                        return "Large Decaf Cowboy Coffee";
                    }
                    return "Large Cowboy Coffee";
                default:
                    throw new NotImplementedException();   
            }
        }

    }
}
