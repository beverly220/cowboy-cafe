using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates an order as a list of iorderitems
    /// </summary>
    public class Order : INotifyPropertyChanged {

        /// <summary>
        /// Creates an event when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The list that contains the iorderitems
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// The ienumerable list that contains the iorderitems
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        private uint lastOrderNumber => 100;

        /// <summary>
        /// The total price of the order
        /// </summary>
        public double Subtotal { get; set; } = 0;

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">the item added to the order</param>
        public void Add(IOrderItem item) {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            Subtotal += item.Price;
            
        }

        public void Remove(IOrderItem item ) {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            Subtotal -= item.Price;
        }

    }

}
