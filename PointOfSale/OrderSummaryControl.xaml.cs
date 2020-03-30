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
        }

        /// <summary>
        /// Reopens customization for a menu item
        /// </summary>
        /// <param name="sender">the listboxitem </param>
        /// <param name="args"></param>
        void ChangePastItem(object sender, SelectionChangedEventArgs args) {
            IOrderItem item = ((sender as ListBox).SelectedItem as IOrderItem);
            var oC = this.FindAncestor<OrderControl>();
            if (item is Side side) {
                var screen = new SideCustomizationScreen(side, oC);
                    OpenCustomScreen(side, screen);
            }
            else if (item is Entree entree) {
                if (item is AngryChicken ac) {
                    var screen = new EntreeCustomizeScreen(ac, oC);
                    OpenCustomScreen(entree, screen);
                }
                else if (item is CowpokeChili cc) {
                    var screen = new EntreeCustomizeScreen(cc, oC);
                    OpenCustomScreen(entree, screen);
                }
                else if (item is DakotaDoubleBurger ddb) {
                    var screen = new EntreeCustomizeScreen(ddb, oC);
                    OpenCustomScreen(entree, screen);
                }
                else if (item is PecosPulledPork ppp) {
                    var screen = new EntreeCustomizeScreen(ppp, oC);
                    OpenCustomScreen(entree, screen);
                }
                else if (item is RustlersRibs) {
                    //Nothing, can't change
                }
                else if (item is TexasTripleBurger ttb) {
                    var screen = new EntreeCustomizeScreen(ttb, oC);
                    OpenCustomScreen(entree, screen);
                }
                else if (item is TrailBurger tb) {
                    var screen = new EntreeCustomizeScreen(tb, oC);
                    OpenCustomScreen(entree, screen);
                }
            }
            else if (item is Drink drink) {
                if (item is CowboyCoffee cc) {
                    var screen = new DrinksCustomizeScreen(cc, oC);
                    OpenCustomScreen(drink, screen);
                }
                else if (item is JerkedSoda js) {
                    var screen = new DrinksCustomizeScreen(js, oC);
                    OpenCustomScreen(drink, screen);
                }
                else if (item is TexasTea tt) {
                    var screen = new DrinksCustomizeScreen(tt, oC);
                    OpenCustomScreen(drink, screen);
                }
                else if (item is Water w) {
                    var screen = new DrinksCustomizeScreen(w, oC);
                    OpenCustomScreen(drink, screen);
                }
            }
            
        }

        /// <summary>
        /// Opens the customize screen for a menu item
        /// </summary>
        /// <param name="item">the item being ordered</param>
        /// <param name="screen">the screen to customize the item</param>
        public void OpenCustomScreen(IOrderItem item, FrameworkElement screen) {
            var order = DataContext as Order;
            if (order == null) {
                throw new Exception("DataContext expected to be an Order instance");
            }
            if (screen != null) {
                var oC = this.FindAncestor<OrderControl>();
                if (oC == null) {
                    throw new Exception("An ancestor of OrderControl cannot be found");
                }
                screen.DataContext = item;
                oC.SwapScreen(screen);
            }
        }
    }
}
