using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates a Trailburger entree object
    /// </summary>
    public class TrailBurger : Entree {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price {
			get {
				NotifyOfPropertyChanged("Price");
				return 4.50;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public override uint Calories {
			get {
				return 288;
			}
		}

		/// <summary>
		/// Defaults the TrailBurger to have a bun
		/// </summary>
		private bool bun = true;

		/// <summary>
		/// If the entree should be served with a bun
		/// </summary>
		public bool Bun {
			get {
				return bun;
			}
			set {
				bun = value;
				NotifyOfPropertyChanged("Bun");
			}
		}

		/// <summary>
		/// Defaults the TrailBurger to have ketchup
		/// </summary>
		private bool ketchup = true;

		/// <summary>
		/// If the entree should be served with ketchup
		/// </summary>
		public bool Ketchup {
			get {
				return ketchup;
			}
			set {
				bun = value;
				NotifyOfPropertyChanged("Ketchup");
			}
		}

		/// <summary>
		/// Defaults the TrailBurger to have mustard
		/// </summary>
		private bool mustard = true;

		/// <summary>
		/// If the entree should be served with mustard
		/// </summary>
		public bool Mustard {
			get {
				return mustard;
			}
			set {
				bun = value;
				NotifyOfPropertyChanged("Mustard");
			}
		}

		/// <summary>
		/// Defaults the TrailBurger to have a pickle
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
				bun = value;
				NotifyOfPropertyChanged("Pickle");
			}
		}

		/// <summary>
		/// Defaults the TrailBurger to have cheese
		/// </summary>
		private bool cheese = true;

		/// <summary>
		/// If the entree should be served with cheese
		/// </summary>
		public bool Cheese {
			get {
				return cheese;
			}
			set {
				bun = value;
				NotifyOfPropertyChanged("Cheese");
			}
		}


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
			return "Trail Burger" + append;
		}

	}
}
