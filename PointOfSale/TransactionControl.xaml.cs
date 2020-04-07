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
using Extensions;
using CashRegister;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl {
        public TransactionControl() {
            InitializeComponent();
            PayWithCash.Click += OnCashPaymentClicked;
            PayWithCredit.Click += OnCreditPaymentClicked;
        }

        /// <summary>
        /// Creates a click event for the Cash button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCashPaymentClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.SwapScreen(new DontDeleteControl());
        }

        /// <summary>
        /// Creates a click event for the Credit button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCreditPaymentClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            CardTerminal terminal = new CardTerminal();
            ResultCode result = ResultCode.InsufficentFunds;
            if (DataContext is Order o) {
                result = terminal.ProcessTransaction(o.Subtotal);
                if (result != ResultCode.Success) {
                    MessageBox.Show("Card Reader Error - Try Again", "ERROR", MessageBoxButton.OK);
                }
                else {
                    ReceiptPrinter receipt = new ReceiptPrinter();
                    receipt.Print(o.ToString());
                    orderControl.Stupid();
                    orderControl.SwapScreen(new MenuItemSelectionControl());
                }
            }
            else {
                MessageBox.Show("Coding Error - Try Again", "ERROR", MessageBoxButton.OK);
            }
            
        }
    }
}
