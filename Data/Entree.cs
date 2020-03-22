using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data {

    /// <summary>
    /// A base class representing an entree
    /// </summary>
    public abstract class Entree : IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Event handler for the entree
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the calories of each entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Updates if a Property is Changed
        /// </summary>
        /// <param name="name">the entree changed</param>
        protected void NotifyOfPropertyChanged(string name) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }
    }
}
