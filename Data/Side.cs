using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged {

        /// <summary>
        /// Event handler for the side
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Defaults all sizes to small
        /// </summary>
        private Size size = Size.Small;


        /// <summary>
        /// Gets the size of the entree
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
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

    }
}
