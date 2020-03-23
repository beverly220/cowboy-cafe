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
    /// Interaction logic for DrinksCustomizeScreen.xaml
    /// </summary>
    public partial class DrinksCustomizeScreen : UserControl {
        public DrinksCustomizeScreen(Drink drink, OrderControl orderC) {
            InitializeComponent();
            CurrentDrink = drink;
            orderControl = orderC;
            SmallSize.Click += OnAddSmallSizeClicked;
            MediumSize.Click += OnAddMediumSizeClicked;
            LargeSize.Click += OnAddLargeSizeClicked;
            AddIce.Click += OnAddIceClicked;
            AddLemon.Click += OnAddLemonClicked;
            AddUnsweet.Click += OnAddUnsweetClicked;
            AddDecaf.Click += OnAddDecafClicked;
            AddRoomForCream.Click += OnAddRoomForCreamClicked;
            SodaIsCreamSoda.Click += OnAddSodaIsCreamSodaClicked;
            SodaIsOrangeSoda.Click += OnAddSodaIsOrangeSodaClicked;
            SodaIsSarsparilla.Click += OnAddSodaIsSarsparillaClicked;
            SodaIsBirchBeer.Click += OnAddSodaIsBirchBeerClicked;
            SodaIsRootBeer.Click += OnAddSodaIsRootBeerClicked;
            DoneEditing.Click += OnAddDoneEditingClicked;
        }

        /// <summary>
        /// Holds the type of drink being customized
        /// </summary>
        Drink CurrentDrink;

        /// <summary>
        /// Holds the order control
        /// </summary>
        OrderControl orderControl;

        /// <summary>
        /// Creates a click event for the Done Editing button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDoneEditingClicked(object sender, RoutedEventArgs e) {
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Creates a click event for the Small button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSmallSizeClicked(object sender, RoutedEventArgs e) {
            CurrentDrink.Size = CowboyCafe.Data.Size.Small;
        }

        /// <summary>
        /// Creates a click event for the Medium button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddMediumSizeClicked(object sender, RoutedEventArgs e) {
            CurrentDrink.Size = CowboyCafe.Data.Size.Medium;
        }

        /// <summary>
        /// Creates a click event for the Large button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddLargeSizeClicked(object sender, RoutedEventArgs e) {
            CurrentDrink.Size = CowboyCafe.Data.Size.Large;
        }

        /// <summary>
        /// Creates a click event for the Ice button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddIceClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is CowboyCoffee cc) {
                if (cc.Ice == true) {
                    cc.Ice = false;
                }
                else {
                    cc.Ice = true;
                }
            }
            else if (CurrentDrink is TexasTea tt) {
                if (tt.Ice == true) {
                    tt.Ice = false;
                }
                else {
                    tt.Ice = true;
                }
            }
            else if (CurrentDrink is JerkedSoda js) {
                if (js.Ice == true) {
                    js.Ice = false;
                }
                else {
                    js.Ice = true;
                }
            }
            else if (CurrentDrink is Water w) {
                if (w.Ice == true) {
                    w.Ice = false;
                }
                else {
                    w.Ice = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Decaf button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDecafClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is CowboyCoffee cc) {
                if (cc.Decaf == true) {
                    cc.Decaf = false;
                }
                else {
                    cc.Decaf = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the RoomForCream button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRoomForCreamClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is CowboyCoffee cc) {
                if (cc.RoomForCream == true) {
                    cc.RoomForCream = false;
                }
                else {
                    cc.RoomForCream = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Sweet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddUnsweetClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is TexasTea tt) {
                if (tt.Sweet == true) {
                    tt.Sweet = false;
                }
                else {
                    tt.Sweet = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Sweet button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddLemonClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is TexasTea tt) {
                if (tt.Lemon == true) {
                    tt.Lemon = false;
                }
                else {
                    tt.Lemon = true;
                }
            }
            else if (CurrentDrink is Water w) {
                if (w.Lemon == true) {
                    w.Lemon = false;
                }
                else {
                    w.Lemon = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Cream Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSodaIsCreamSodaClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is JerkedSoda js) {
                js.Flavor = SodaFlavor.CreamSoda;
            }
        }

        /// <summary>
        /// Creates a click event for the Orange Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSodaIsOrangeSodaClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is JerkedSoda js) {
                js.Flavor = SodaFlavor.OrangeSoda;
            }
        }

        /// <summary>
        /// Creates a click event for the Sarsparilla button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSodaIsSarsparillaClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is JerkedSoda js) {
                js.Flavor = SodaFlavor.Sarsparilla;
            }
        }

        /// <summary>
        /// Creates a click event for the Birch Beer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSodaIsBirchBeerClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is JerkedSoda js) {
                js.Flavor = SodaFlavor.BirchBeer;
            }
        }

        /// <summary>
        /// Creates a click event for the RootBeer button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSodaIsRootBeerClicked(object sender, RoutedEventArgs e) {
            if (CurrentDrink is JerkedSoda js) {
                js.Flavor = SodaFlavor.RootBeer;
            }
        }
    }
}

