using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data {

    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Event handler for the entree
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the calories of each drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Defaults all sizes to small
        /// </summary>
        private Size size = Size.Small;

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size {
            get {
                return size;
            }
            set {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
            }
        }

        /// <summary>
        /// If the drink comes with ice
        /// </summary>
        public virtual bool Ice { get; set; } = true;

        /// <summary>
        /// Updates if a Property is Changed
        /// </summary>
        /// <param name="name">the drink changed</param>
        protected void NotifyOfPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

    }

}

