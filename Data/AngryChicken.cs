using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

	/// <summary>
	/// Creates an AngryChicken entree object
	/// </summary>
	public class AngryChicken {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public double Price {
			get {
				return 5.99;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public uint Calories {
			get {
				return 190;
			}
		}

        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

		/// <summary>
		/// If the entree should be served with bread
		/// </summary>
		public bool Bread { get; set; } = true;


		/// <summary>
		/// Any changes needing to be made from the original recipe
		/// </summary>
		public List<string> SpecialInstructions {
			get {
				List<string> instructions = new List<string>();
				if (!Bread) {
					instructions.Add("hold bread");
				}
				if (!Pickle) {
					instructions.Add("hold pickle");
				}
				return instructions;
			}
		}

	}

}