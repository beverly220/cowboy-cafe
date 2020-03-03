using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data {

    /// <summary>
    /// Holds the singular global variable
    /// </summary>
    public static class Global {
        /// <summary>
        /// Last order's number
        /// </summary>
        public static uint lastOrderNumber { get; set; } = 1;

    }
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
        /// The list that contains the iorderitem prices
        /// </summary>
        private List<double> itemPrice = new List<double>();

        /// <summary>
        /// The ienumerable list that contains the iorderitems
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// The ienumerable list that contains the iorderitem
        /// prices
        /// </summary>
        public IEnumerable<double> ItemPrices => itemPrice.ToArray();

        /// <summary>
        /// Current order's number
        /// </summary>
        public uint OrderNumber = 100 + Global.lastOrderNumber;

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
            Subtotal += item.Price;
            itemPrice.Add(item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            //PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item">the item removed from the order</param>
        public void Remove(IOrderItem item) {
            items.Remove(item);
            Subtotal -= item.Price;
            itemPrice.Remove(item.Price);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("OrderNumber"));
        }

    }

}
