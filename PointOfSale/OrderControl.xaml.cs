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
        }

        /// <summary>
        /// The current order since it makes more sense
        /// than running in circles with DataContext
        /// </summary>
        Order RelevantOrder = new Order();

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
    }
}
