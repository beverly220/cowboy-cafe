using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Data;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl {

        /// <summary>
        /// Keeps track of the prices for each menu item
        /// individually
        /// </summary>
        public OrderSummaryControl() {
            InitializeComponent();
            if (DataContext is Order data) {
                foreach (IOrderItem item in data.Items) {
                    CurrentOrder.Items.Add(item.ToString());
                    CurrentOrderPrice.Items.Add("$" + item.Price.ToString());
                    if (item.SpecialInstructions != null) {
                        foreach (string s in item.SpecialInstructions) {
                            CurrentOrderPrice.Items.Add(" ");
                            CurrentOrder.Items.Add(item.SpecialInstructions.ToString());
                        }
                    }
                }
            }
        }
    }
}
