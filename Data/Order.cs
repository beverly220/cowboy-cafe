using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data {

    /// <summary>
    /// Creates an order as a list of iorderitems
    /// </summary>
    public class Order : INotifyPropertyChanged {

        private static uint Increment = 1;

        /// <summary>
        /// Last order's number
        /// </summary>
        private static uint lastOrderNumber {
            get {
                Increment += 1;
                return Increment;
            }
        }

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
        public uint OrderNumber {
            get { 
                return 100 + lastOrderNumber;
            }
        }

        /// <summary>
        /// The total price of the order
        /// </summary>
        public double Subtotal { get; private set; } = 0;

        /// <summary>
        /// The total tax of the order
        /// </summary>
        public double Tax { get; private set; } = 0;

        /// <summary>
        /// Adds an item to the order
        /// </summary>
        /// <param name="item">the item added to the order</param>
        public void Add(IOrderItem item) {
            if(item is INotifyPropertyChanged notify) {
                notify.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            Subtotal += item.Price;
            Tax += (.16 * item.Price);
            Subtotal += (.16 * item.Price);
            itemPrice.Add(item.Price);
        }

        /// <summary>
        /// Removes an item from the order
        /// </summary>
        /// <param name="item">the item removed from the order</param>
        public void Remove(IOrderItem item) {
            if (item is INotifyPropertyChanged notify) {
                notify.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            Subtotal -= item.Price;
            Tax -= (.16 * item.Price);
            Subtotal -= Tax;
            itemPrice.Remove(item.Price);
            
        }

        public void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e) {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("ItemPrices"));
            if (e.PropertyName == "Price") {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Tax"));
            }
        }

        public override string ToString() {
            StringBuilder sb = new StringBuilder();
            sb.Append("Order Number " + OrderNumber.ToString());
            sb.AppendLine();
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            foreach (IOrderItem i in items) {
                sb.Append(i.ToString() + "   " + i.Price.ToString());
                sb.AppendLine();
            }
            sb.Append("Tax is " + Tax.ToString());
            sb.AppendLine();
            sb.Append("Total is" + Subtotal.ToString());
            sb.AppendLine();
            sb.Append("Paid with Credit");
            return sb.ToString();
        }

        public string ToString(double cashGiven) {
            StringBuilder sb = new StringBuilder();
            double changeDue = Subtotal - cashGiven;
            sb.Append("Order Number " + OrderNumber.ToString());
            sb.AppendLine();
            sb.Append(DateTime.Now.ToString());
            sb.AppendLine();
            foreach (IOrderItem i in items) {
                sb.Append(i.ToString() + "   " + i.Price.ToString());
                sb.AppendLine();
            }
            sb.Append("Tax is " + Tax.ToString());
            sb.AppendLine();
            sb.Append("Total is" + Subtotal.ToString());
            sb.AppendLine();
            sb.Append("Paid with " + cashGiven.ToString());
            sb.AppendLine();
            sb.Append("Change due " + changeDue.ToString());
            return sb.ToString();
        }
    }

}
