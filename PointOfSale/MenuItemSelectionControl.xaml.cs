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
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl {

        public MenuItemSelectionControl() {
            InitializeComponent();
            AddAngryChicken.Click += OnAddAngryChickenClicked;
            AddBakedBeans.Click += OnAddBakedBeansClicked;
            AddChiliCheeseFries.Click += OnAddChiliCheeseFriesClicked;
            AddCornDodgers.Click += OnAddCornDodgersClicked;
            AddCowboyCoffee.Click += OnAddCowboyCoffeeClicked;
            AddCowpokeChili.Click += OnAddCowpokeChiliClicked;
            AddDakotaDoubleBurger.Click += OnAddDakotaDoubleBurgerClicked;
            AddJerkedSoda.Click += OnAddJerkedSodaClicked;
            AddPanDeCampo.Click += OnAddPanDeCampoClicked;
            AddPecosPulledPork.Click += OnAddPecosPulledPorkClicked;
            AddRustlersRibs.Click += OnAddRustlersRibsClicked;
            AddTexasTea.Click += OnAddTexasTeaClicked;
            AddTexasTripleBurger.Click += OnAddTexasTripleBurgerClicked;
            AddTrailBurger.Click += OnAddTrailburgerClicked;
            AddWater.Click += OnAddWaterClicked;
        }

        /// <summary>
        /// Opens the customize screen for a menu item
        /// </summary>
        /// <param name="item">the item being ordered</param>
        /// <param name="screen">the screen to customize the item</param>
        public void AddItemAndOpenCustomScreen(IOrderItem item, FrameworkElement screen) {
            var order = DataContext as Order;
            if (order == null) {
                throw new Exception("DataContext expected to be an Order instance");
            }
            if (screen != null) {
                var orderControl = this.FindAncestor<OrderControl>();
                if(orderControl == null) {
                    throw new Exception("An ancestor of OrderControl cannot be found");
                }
                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }
            order.Add(item);
        }


        /// <summary>
        /// Creates a click event for the Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddAngryChickenClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new AngryChicken();
                var screen = new EntreeCustomizeScreen(item, orderControl);
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
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddBakedBeansClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new BakedBeans();
                var screen = new SideCustomizationScreen(item, orderControl);
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new ChiliCheeseFries();
                var screen = new SideCustomizationScreen(item, orderControl);
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCornDodgersClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new CornDodgers();
                var screen = new SideCustomizationScreen(item, orderControl);
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new CowboyCoffee();
                var screen = new DrinksCustomizeScreen(item, orderControl);
                screen.AddUnsweet.IsEnabled = false;
                screen.AddLemon.IsEnabled = false;
                screen.SodaIsSarsparilla.IsEnabled = false;
                screen.SodaIsCreamSoda.IsEnabled = false;
                screen.SodaIsOrangeSoda.IsEnabled = false;
                screen.SodaIsRootBeer.IsEnabled = false;
                screen.SodaIsBirchBeer.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Cowpoke Chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddCowpokeChiliClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new CowpokeChili();
                var screen = new EntreeCustomizeScreen(item, orderControl);
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
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new DakotaDoubleBurger();
                var screen = new EntreeCustomizeScreen(item, orderControl);
                screen.RemoveBread.IsEnabled = false;
                screen.RemoveSourCream.IsEnabled = false;
                screen.RemoveGreenOnion.IsEnabled = false;
                screen.RemoveTortillaStrips.IsEnabled = false;
                screen.RemoveBacon.IsEnabled = false;
                screen.RemoveEgg.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Jerked Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new JerkedSoda();
                var screen = new DrinksCustomizeScreen(item, orderControl);
                screen.AddDecaf.IsEnabled = false;
                screen.AddRoomForCream.IsEnabled = false;
                screen.AddUnsweet.IsEnabled = false;
                screen.AddLemon.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Pan de Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new PanDeCampo();
                var screen = new SideCustomizationScreen(item, orderControl);
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Pecos Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new PecosPulledPork();
                var screen = new EntreeCustomizeScreen(item, orderControl);
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
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Rustler's Ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new RustlersRibs();
                AddItemAndOpenCustomScreen(item, null);
            }
        }

        /// <summary>
        /// Creates a click event for the Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTexasTeaClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new TexasTea();
                var screen = new DrinksCustomizeScreen(item, orderControl);
                screen.AddDecaf.IsEnabled = false;
                screen.AddRoomForCream.IsEnabled = false;
                screen.SodaIsSarsparilla.IsEnabled = false;
                screen.SodaIsCreamSoda.IsEnabled = false;
                screen.SodaIsOrangeSoda.IsEnabled = false;
                screen.SodaIsRootBeer.IsEnabled = false;
                screen.SodaIsBirchBeer.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }
    

        /// <summary>
        /// Creates a click event for the Texas Triple Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new TexasTripleBurger();
                var screen = new EntreeCustomizeScreen(item, orderControl);
                screen.RemoveBread.IsEnabled = false;
                screen.RemoveSourCream.IsEnabled = false;
                screen.RemoveGreenOnion.IsEnabled = false;
                screen.RemoveTortillaStrips.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTrailburgerClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new TrailBurger();
                var screen = new EntreeCustomizeScreen(item, orderControl);
                screen.RemoveBread.IsEnabled = false;
                screen.RemoveSourCream.IsEnabled = false;
                screen.RemoveGreenOnion.IsEnabled = false;
                screen.RemoveTortillaStrips.IsEnabled = false;
                screen.RemoveLettuce.IsEnabled = false;
                screen.RemoveTomato.IsEnabled = false;
                screen.RemoveMayo.IsEnabled = false;
                screen.RemoveBacon.IsEnabled = false;
                screen.RemoveEgg.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

        /// <summary>
        /// Creates a click event for the Water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddWaterClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            if (sender is Button) {
                var item = new Water();
                var screen = new DrinksCustomizeScreen(item, orderControl);
                screen.AddDecaf.IsEnabled = false;
                screen.AddRoomForCream.IsEnabled = false;
                screen.AddUnsweet.IsEnabled = false;
                screen.SodaIsSarsparilla.IsEnabled = false;
                screen.SodaIsCreamSoda.IsEnabled = false;
                screen.SodaIsOrangeSoda.IsEnabled = false;
                screen.SodaIsRootBeer.IsEnabled = false;
                screen.SodaIsBirchBeer.IsEnabled = false;
                AddItemAndOpenCustomScreen(item, screen);
            }
        }

    }
}
