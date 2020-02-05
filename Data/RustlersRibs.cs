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

	}
}
