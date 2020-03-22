using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

	/// <summary>
	/// Creates an AngryChicken entree object
	/// </summary>
	public class AngryChicken : Entree {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price {
			get {
				return 5.99;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public override uint Calories {
			get {
				return 190;
			}
		}


		/// <summary>
		/// Defaults the Angry Chicken to have a pickle
		/// </summary>
		private bool pickle = true;

		/// <summary>
		/// If the entree should be served with a pickle
		/// </summary>
		public bool Pickle {
			get {
				return pickle;
			}
			set {
				pickle = value;
				NotifyOfPropertyChanged("Pickle");
			}
		}

		/// <summary>
		/// Defaults the Angry Chicken to have bread
		/// </summary>
		private bool bread = true;

		/// <summary>
		/// If the entree should be served with bread
		/// </summary>
		public bool Bread {
			get {
				return bread;
			}
			set {
				bread = value;
				NotifyOfPropertyChanged("Bread");
			}
		}


		/// <summary>
		/// Any changes needing to be made from the original recipe
		/// </summary>
		public override List<string> SpecialInstructions {
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

		/// <summary>
		/// Makes the name of the entree more user friendly
		/// </summary>
		/// <returns>The name of the entree</returns>
		public override string ToString() {
			return "Angry Chicken";
		}

	}

}