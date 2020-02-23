using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Dakota Double Burger entree object
    /// </summary>
    public class DakotaDoubleBurger : Entree {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price {
			get {
				return 5.20;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public override uint Calories {
			get {
				return 464;
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
		/// If the entree should be served with tomato
		/// </summary>
		public bool Tomato { get; set; } = true;

		/// <summary>
		/// If the entree should be served with lettuce
		/// </summary>
		public bool Lettuce { get; set; } = true;

		/// <summary>
		/// If the entree should be served with mayo
		/// </summary>
		public bool Mayo { get; set; } = true;

		/// <summary>
		/// Any changes needing to be made from the original recipe
		/// </summary>
		public override List<string> SpecialInstructions {
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
				if (!Tomato) {
					instructions.Add("hold tomato");
				}
				if (!Lettuce) {
					instructions.Add("hold lettuce");
				}
				if (!Mayo) {
					instructions.Add("hold mayo");
				}
				return instructions;
			}
		}

		/// <summary>
		/// Makes the name of the entree more user friendly
		/// </summary>
		/// <returns>The name of the entree</returns>
		public override string ToString() {
			return "Dakota Double Burger";
		}

	}
}
