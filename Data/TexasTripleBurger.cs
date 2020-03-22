using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data {

	/// <summary>
	/// Creates a Texas Triple Burger entree object
	/// </summary>
    public class TexasTripleBurger : Entree {

		/// <summary>
		/// The price of the entree
		/// </summary>
		public override double Price {
			get {
				return 6.45;
			}
		}

		/// <summary>
		/// The amount of calories the entree is
		/// </summary>
		public override uint Calories {
			get {
				return 698;
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have a bun
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
		/// Defaults the Texas Triple Burger to have ketchup
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
				ketchup = value;
				NotifyOfPropertyChanged("Ketchup");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have mustard
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
				mustard = value;
				NotifyOfPropertyChanged("Mustard");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have a pickle
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
		/// Defaults the Texas Triple Burger to have cheese
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
				cheese = value;
				NotifyOfPropertyChanged("Cheese");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have tomato
		/// </summary>
		private bool tomato = true;

		/// <summary>
		/// If the entree should be served with tomato
		/// </summary>
		public bool Tomato {
			get {
				return tomato;
			}
			set {
				tomato = value;
				NotifyOfPropertyChanged("Tomato");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have lettuce
		/// </summary>
		private bool lettuce = true;

		/// <summary>
		/// If the entree should be served with lettuce
		/// </summary>
		public bool Lettuce {
			get {
				return lettuce;
			}
			set {
				lettuce = value;
				NotifyOfPropertyChanged("Lettuce");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have mayo
		/// </summary>
		private bool mayo = true;

		/// <summary>
		/// If the entree should be served with mayo
		/// </summary>
		public bool Mayo {
			get {
				return mayo;
			}
			set {
				mayo = value;
				NotifyOfPropertyChanged("Mayo");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have bacon
		/// </summary>
		private bool bacon = true;

		/// <summary>
		/// If the entree should be served with bacon
		/// </summary>
		public bool Bacon {
			get {
				return bacon;
			}
			set {
				bacon = value;
				NotifyOfPropertyChanged("Bacon");
			}
		}

		/// <summary>
		/// Defaults the Texas Triple Burger to have egg
		/// </summary>
		private bool egg = true;

		/// <summary>
		/// If the entree should be served with egg
		/// </summary>
		public bool Egg {
			get {
				return egg;
			}
			set {
				egg = value;
				NotifyOfPropertyChanged("Egg");
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
				if (!Tomato) {
					instructions.Add("hold tomato");
				}
				if (!Lettuce) {
					instructions.Add("hold lettuce");
				}
				if (!Mayo) {
					instructions.Add("hold mayo");
				}
				if (!Bacon) {
					instructions.Add("hold bacon");
				}
				if (!Egg) {
					instructions.Add("hold egg");
				}
				return instructions;
			}
		}

		/// <summary>
		/// Makes the name of the entree more user friendly
		/// </summary>
		/// <returns>The name of the entree</returns>
		public override string ToString() {
			return "Texas Triple Burger";
		}

	}
}
