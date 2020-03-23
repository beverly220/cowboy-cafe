using System;
using System.Collections.Generic;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowpoke Chili entree
    /// </summary>
    public class CowpokeChili : Entree
    {

        /// <summary>
        /// Defaults the Cowpoke Chili to have cheese
        /// </summary>
        private bool cheese = true;

        /// <summary>
        /// If the chili is topped with cheese
        /// </summary>
        public bool Cheese {
            get {
                return cheese;
            }
            set {
                cheese = value;
                NotifyOfPropertyChanged("Cheese");
            }
        }

        /// <summary>
        /// Defaults the Cowpoke Chili to have sour cream
        /// </summary>
        private bool sourCream = true;

        /// <summary>
        /// If the chili is topped with sour cream
        /// </summary>
        public bool SourCream {
            get {
                return sourCream;
            }
            set {
                sourCream = value;
                NotifyOfPropertyChanged("SourCream");
            }
        }

        /// <summary>
        /// Defaults the Cowpoke Chili to have green onions
        /// </summary>
        private bool greenOnions = true;

        /// <summary>
        /// If the chili is topped with green onions
        /// </summary>
        public bool GreenOnions {
            get {
                return greenOnions;
            }
            set {
                greenOnions = value;
                NotifyOfPropertyChanged("GreenOnions");
            }
        }

        /// <summary>
        /// Defaults the Cowpoke Chili to have torilla strips
        /// </summary>
        private bool tortillaStrips = true;

        /// <summary>
        /// If the chili is topped with tortilla strips
        /// </summary>
        public bool TortillaStrips {
            get {
                return tortillaStrips;
            }
            set {
                tortillaStrips = value;
                NotifyOfPropertyChanged("TortillaStrips");
            }
        }

        /// <summary>
        /// The price of the chili
        /// </summary>
        public override double Price
        {
            get
            {
                NotifyOfPropertyChanged("Price");
                return 6.10;
            }
        }

        /// <summary>
        /// The calories of the chili
        /// </summary>
        public override uint Calories
        {
            get
            {
                return 171;
            }
        }

        /// <summary>
        /// Special instructions for the preparation of the chili
        /// </summary>
        public override List<string> SpecialInstructions {
            get {
                var instructions = new List<string>();

                if (!Cheese) instructions.Add("hold cheese");
                if (!SourCream) instructions.Add("hold sour cream");
                if (!GreenOnions) instructions.Add("hold green onions");
                if (!TortillaStrips) instructions.Add("hold tortilla strips");

                return instructions;
            }
        }

        /// <summary>
        /// Makes the name of the entree more user friendly
        /// </summary>
        /// <returns>The name of the entree</returns>
        public override string ToString() {
            string append = "";
            foreach (string s in SpecialInstructions) {
                append += " ";
                append += s;
            }
            return "Cowpoke Chili" + append;
        }

    }
}

