using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Texas Tea object to 
    /// represent the drink
    /// </summary>
    public class TexasTea : Drink {

        /// <summary>
        /// Defaults the Texas Tea to have ice
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
        /// Defaults the Texas Tea to have a lemon
        /// </summary>
        private bool lemon = false;

        /// <summary>
        /// If served with a lemon
        /// </summary>
        public bool Lemon {
            get {
                return lemon;
            }
            set {
                lemon = value;
                NotifyOfPropertyChanged("Lemon");
            }
        }

        /// <summary>
        /// Defaults the Texas Tea to be sweet
        /// </summary>
        private bool sweet = true;

        /// <summary>
        /// If sweet or unsweet tea
        /// </summary>
        public bool Sweet {
            get {
                return sweet;
            }
            set {
                sweet = value;
                NotifyOfPropertyChanged("Sweet");
            }
        }

        /// <summary>
        /// Returns the correct calories based on the
        /// size of the selected drink
        /// </summary>
        public override uint Calories {
            get {
                if (!Sweet) {
                    switch (Size) {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else {
                    switch (Size) {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                if (!Sweet) instructions.Add("Unsweet Tea");
                if (Lemon) instructions.Add("Add Lemon");
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
                    if (Sweet) {
                        return "Small Texas Sweet Tea";
                    }
                    return "Small Texas Plain Tea";
                case Size.Medium:
                    if (Sweet) {
                        return "Medium Texas Sweet Tea";
                    }
                    return "Medium Texas Plain Tea";
                case Size.Large:
                    if (Sweet) {
                        return "Large Texas Sweet Tea";
                    }
                    return "Large Texas Plain Tea";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
