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
using CashRegister;

namespace PointOfSale {

    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl {

        /// <summary>
        /// Initializing the Order Control and making all of the buttons able to work
        /// </summary>
        public OrderControl() {
            InitializeComponent();
            DataContext = new Order();
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;
            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
            CurrentDrawer.AddBill(Bills.One, 25);
            CurrentDrawer.AddBill(Bills.Five, 10);
            CurrentDrawer.AddBill(Bills.Ten, 2);
            CurrentDrawer.AddCoin(Coins.Penny, 75);
            CurrentDrawer.AddCoin(Coins.Nickel, 20);
            CurrentDrawer.AddCoin(Coins.Dime, 10);
        }

        /// <summary>
        /// The cash drawer
        /// </summary>
        public CashDrawer CurrentDrawer = new CashDrawer();

        /// <summary>
        /// Switches to customization screen
        /// </summary>
        /// <param name="element">screen given</param>
        public void SwapScreen (UIElement element) {
            Container.Child = element;
        }

        /// <summary>
        /// Handles if the Item Selection Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e) {
            Container.Child = new MenuItemSelectionControl();
        }

        /// <summary>
        /// Handles if the Cancel Order Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e) {
            DataContext = new Order();
        }

        /// <summary>
        /// Handles if the Complete Order Button is pressed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e) { 
            SwapScreen(new TransactionControl());
        }

        /// <summary>
        /// Helper method for Transaction Control
        /// </summary>
        public void Stupid() {
            DataContext = new Order();
        }

        public void GivenExactCash(double given) {
            MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
            ReceiptPrinter receipt = new ReceiptPrinter();
            var o = DataContext as Order;
            receipt.Print(o.ToString(given));
            Stupid();
            SwapScreen(new OrderSummaryControl());
        }

        public void GivenMoreCash(double given) {
            ReceiptPrinter receipt = new ReceiptPrinter();
            var o = DataContext as Order;
            receipt.Print(o.ToString(given));
            Stupid();
            SwapScreen(new OrderSummaryControl());
        }
    }
}
