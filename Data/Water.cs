using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Water object to
    /// represent the drink
    /// </summary>
    public class Water : Drink {

        /// <summary>
        /// Defaults the Water to have ice
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
        /// Defaults the Water to have a lemon
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
        /// Returns the correct calories based on the
        /// size of the selected drink
        /// </summary>
        public override uint Calories {
            get {
                return 0;
            }
        }

        /// <summary>
        /// Returns the correct price of the drink based on 
        /// the selected size
        /// </summary>
        public override double Price {
            get {
                return 0.12;
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
                    return "Small Water";
                case Size.Medium:
                    return "Medium Water";
                case Size.Large:
                    return "Large Water";
                default:
                    throw new NotImplementedException();
            }
        }

    }
}
