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
                    screen.RemoveCheese.IsEnabled = false;
                    screen.RemoveSourCream.IsEnabled = false;
                    screen.RemoveGreenOnion.IsEnabled = false;
                    screen.RemoveTortillaStrips.IsEnabled = false;
                    screen.RemoveLettuce.IsEnabled = false;
                    screen.RemoveBun.IsEnabled = false;
                    screen.RemoveKetchup.IsEnabled = false;
                    screen.RemoveMustard.IsEnabled = false;
                    screen.RemoveTomato.IsEnabled = false;
                    screen.RemoveMayo.IsEnabled = false;
                    screen.RemoveBacon.IsEnabled = false;
                    screen.RemoveEgg.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
                else if (item is CowpokeChili cc) {
                    var screen = new EntreeCustomizeScreen(cc, oC);
                    screen.RemovePickle.IsEnabled = false;
                    screen.RemoveBread.IsEnabled = false;
                    screen.RemoveLettuce.IsEnabled = false;
                    screen.RemoveBun.IsEnabled = false;
                    screen.RemoveKetchup.IsEnabled = false;
                    screen.RemoveMustard.IsEnabled = false;
                    screen.RemoveTomato.IsEnabled = false;
                    screen.RemoveMayo.IsEnabled = false;
                    screen.RemoveBacon.IsEnabled = false;
                    screen.RemoveEgg.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
                else if (item is DakotaDoubleBurger ddb) {
                    var screen = new EntreeCustomizeScreen(ddb, oC);
                    screen.RemoveBread.IsEnabled = false;
                    screen.RemoveSourCream.IsEnabled = false;
                    screen.RemoveGreenOnion.IsEnabled = false;
                    screen.RemoveTortillaStrips.IsEnabled = false;
                    screen.RemoveBacon.IsEnabled = false;
                    screen.RemoveEgg.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
                else if (item is PecosPulledPork ppp) {
                    var screen = new EntreeCustomizeScreen(ppp, oC);
                    screen.RemoveCheese.IsEnabled = false;
                    screen.RemoveSourCream.IsEnabled = false;
                    screen.RemoveGreenOnion.IsEnabled = false;
                    screen.RemoveTortillaStrips.IsEnabled = false;
                    screen.RemoveLettuce.IsEnabled = false;
                    screen.RemoveBun.IsEnabled = false;
                    screen.RemoveKetchup.IsEnabled = false;
                    screen.RemoveMustard.IsEnabled = false;
                    screen.RemoveTomato.IsEnabled = false;
                    screen.RemoveMayo.IsEnabled = false;
                    screen.RemoveBacon.IsEnabled = false;
                    screen.RemoveEgg.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
                else if (item is RustlersRibs) {
                    OpenCustomScreen(entree, new MenuItemSelectionControl());
                }
                else if (item is TexasTripleBurger ttb) {
                    var screen = new EntreeCustomizeScreen(ttb, oC);
                    screen.RemoveBread.IsEnabled = false;
                    screen.RemoveSourCream.IsEnabled = false;
                    screen.RemoveGreenOnion.IsEnabled = false;
                    screen.RemoveTortillaStrips.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
                else if (item is TrailBurger tb) {
                    var screen = new EntreeCustomizeScreen(tb, oC);
                    screen.RemoveBread.IsEnabled = false;
                    screen.RemoveSourCream.IsEnabled = false;
                    screen.RemoveGreenOnion.IsEnabled = false;
                    screen.RemoveTortillaStrips.IsEnabled = false;
                    screen.RemoveLettuce.IsEnabled = false;
                    screen.RemoveTomato.IsEnabled = false;
                    screen.RemoveMayo.IsEnabled = false;
                    screen.RemoveBacon.IsEnabled = false;
                    screen.RemoveEgg.IsEnabled = false;
                    OpenCustomScreen(entree, screen);
                }
            }
            else if (item is Drink drink) {
                if (item is CowboyCoffee cc) {
                    var screen = new DrinksCustomizeScreen(cc, oC);
                    screen.AddUnsweet.IsEnabled = false;
                    screen.AddLemon.IsEnabled = false;
                    screen.SodaIsSarsparilla.IsEnabled = false;
                    screen.SodaIsCreamSoda.IsEnabled = false;
                    screen.SodaIsOrangeSoda.IsEnabled = false;
                    screen.SodaIsRootBeer.IsEnabled = false;
                    screen.SodaIsBirchBeer.IsEnabled = false;
                    OpenCustomScreen(drink, screen);
                }
                else if (item is JerkedSoda js) {
                    var screen = new DrinksCustomizeScreen(js, oC);
                    screen.AddDecaf.IsEnabled = false;
                    screen.AddRoomForCream.IsEnabled = false;
                    screen.AddUnsweet.IsEnabled = false;
                    screen.AddLemon.IsEnabled = false;
                    OpenCustomScreen(drink, screen);
                }
                else if (item is TexasTea tt) {
                    var screen = new DrinksCustomizeScreen(tt, oC);
                    screen.AddDecaf.IsEnabled = false;
                    screen.AddRoomForCream.IsEnabled = false;
                    screen.SodaIsSarsparilla.IsEnabled = false;
                    screen.SodaIsCreamSoda.IsEnabled = false;
                    screen.SodaIsOrangeSoda.IsEnabled = false;
                    screen.SodaIsRootBeer.IsEnabled = false;
                    screen.SodaIsBirchBeer.IsEnabled = false;
                    OpenCustomScreen(drink, screen);
                }
                else if (item is Water w) {
                    var screen = new DrinksCustomizeScreen(w, oC);
                    screen.AddDecaf.IsEnabled = false;
                    screen.AddRoomForCream.IsEnabled = false;
                    screen.AddUnsweet.IsEnabled = false;
                    screen.SodaIsSarsparilla.IsEnabled = false;
                    screen.SodaIsCreamSoda.IsEnabled = false;
                    screen.SodaIsOrangeSoda.IsEnabled = false;
                    screen.SodaIsRootBeer.IsEnabled = false;
                    screen.SodaIsBirchBeer.IsEnabled = false;
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
