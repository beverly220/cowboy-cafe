using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Rustler's Ribs entree object
    /// </summary>
    public class RustlersRibs : Entree {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price {
			get {
				return 7.50;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public override uint Calories {
			get {
				return 894;
			}
		}

		/// <summary>
		/// Any changes needing to be made from the original recipe
		/// </summary>
		public override List<string> SpecialInstructions {
			get {
				List<string> instructions = new List<string>();
				return instructions;
			}
		}

		/// <summary>
		/// Makes the name of the entree more user friendly
		/// </summary>
		/// <returns>The name of the entree</returns>
		public override string ToString() {
			return "Rustler's Ribs";
		}

	}
}
