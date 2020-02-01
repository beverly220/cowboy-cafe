using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Trailburger entree object
    /// </summary>
    class Trailburger {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public double Price {
			get {
				return 4.50;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public uint Calories {
			get {
				return 288;
			}
		}

        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Bun { get; set; } = true;

		/// <summary>
		/// If the entree should be served with ketchup
		/// </summary>
		public bool Ketchup { get; set; } = true;

		/// <summary>
		/// If the entree should be served with mustard
		/// </summary>
		public bool Mustard { get; set; } = true;

		/// <summary>
		/// If the entree should be served with a pickle
		/// </summary>
		public bool Pickle { get; set; } = true;

		/// <summary>
		/// If the entree should be served with cheese
		/// </summary>
		public bool Cheese { get; set; } = true;


		/// <summary>
		/// Any changes needing to be made from the original recipe
		/// </summary>
		public List<string> SpecialInstructions {
			get {
				List<string> instructions = new List<string>();
				if (!Bun) {
					instructions.Add("hold bun");
				}
				if (!Pickle) {
					instructions.Add("hold pickle");
				}
				if (!Ketchup) {
					instructions.Add("hold ketchup");
				}
				if (!Mustard) {
					instructions.Add("hold mustard");
				}
				if (!Cheese) {
					instructions.Add("hold cheese");
				}
				return instructions;
			}
		}

	}
}
