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
using System.ComponentModel;

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for EntreeCustomizeScreen.xaml
    /// </summary>
    public partial class EntreeCustomizeScreen : UserControl {
        public EntreeCustomizeScreen(Entree entree, OrderControl orderC) {
            InitializeComponent();
            CurrentEntree = entree;
            orderControl = orderC;
            DoneEditing.Click += OnAddDoneEditingClicked;
            RemovePickle.Click += OnAddRemovePickleClicked;
            RemoveBread.Click += OnAddRemoveBreadClicked;
            RemoveCheese.Click += OnAddRemoveCheeseClicked;
            RemoveSourCream.Click += OnAddRemoveSourCreamClicked;
            RemoveGreenOnion.Click += OnAddRemoveGreenOnionClicked;
            RemoveTortillaStrips.Click += OnAddRemoveTortillaStripsClicked;
            RemoveLettuce.Click += OnAddRemoveLettuceClicked;
            RemoveBun.Click += OnAddRemoveBunClicked;
            RemoveKetchup.Click += OnAddRemoveKetchupClicked;
            RemoveMustard.Click += OnAddRemoveMustardClicked;
            RemoveTomato.Click += OnAddRemoveTomatoClicked;
            RemoveMayo.Click += OnAddRemoveMayoClicked;
            RemoveBacon.Click += OnAddRemoveBaconClicked;
            RemoveEgg.Click += OnAddRemoveEggClicked;
            RemoveEntree.Click += OnAddRemoveEntreeClicked;
        }

        /// <summary>
        /// Holds the type of side being customized
        /// </summary>
        Entree CurrentEntree;

        /// <summary>
        /// Holds the order control
        /// </summary>
        OrderControl orderControl;

        /// <summary>
        /// Creates a click event for the Remove Entree button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveEntreeClicked(object sender, RoutedEventArgs e) {
            if(orderControl.DataContext is Order o) {
                o.Remove(CurrentEntree);
            }
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Creates a click event for the Done Editing button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDoneEditingClicked(object sender, RoutedEventArgs e) {
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Creates a click event for the Pickle button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemovePickleClicked(object sender, RoutedEventArgs e) {
            if(CurrentEntree is AngryChicken ac) {
                if (ac.Pickle == true) {
                    ac.Pickle = false;
                }
                else {
                    ac.Pickle = true;
                }
            }
            else if(CurrentEntree is PecosPulledPork ppp) {
                if (ppp.Pickle == true) {
                    ppp.Pickle = false;
                }
                else {
                    ppp.Pickle = true;
                }
            }
            else if(CurrentEntree is TrailBurger tb) {
                if (tb.Pickle == true) {
                    tb.Pickle = false;
                }
                else {
                    tb.Pickle = true;
                }
            }
            else if(CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Pickle == true) {
                    ddb.Pickle = false;
                }
                else {
                    ddb.Pickle = true;
                }
            }
            else if(CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Pickle == true) {
                    ttb.Pickle = false;
                }
                else {
                    ttb.Pickle = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Bread button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveBreadClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is AngryChicken ac) {
                if (ac.Bread == true) {
                    ac.Bread = false;
                }
                else {
                    ac.Bread = true;
                }
            }
            else if (CurrentEntree is PecosPulledPork ppp) {
                if (ppp.Bread == true) {
                    ppp.Bread = false;
                }
                else {
                    ppp.Bread = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Cheese button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveCheeseClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is CowpokeChili cc) {
                if (cc.Cheese == true) {
                    cc.Cheese = false;
                }
                else {
                    cc.Cheese = true;
                }
            }
            else if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Cheese == true) {
                    ddb.Cheese = false;
                }
                else {
                    ddb.Cheese = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Cheese == true) {
                    ttb.Cheese = false;
                }
                else {
                    ttb.Cheese = true;
                }
            }
            else if (CurrentEntree is TrailBurger tb) {
                if (tb.Cheese == true) {
                    tb.Cheese = false;
                }
                else {
                    tb.Cheese = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Sour Cream button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveSourCreamClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is CowpokeChili cc) {
                if (cc.SourCream == true) {
                    cc.SourCream = false;
                }
                else {
                    cc.SourCream = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Sour Cream button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveGreenOnionClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is CowpokeChili cc) {
                if (cc.GreenOnions == true) {
                    cc.GreenOnions = false;
                }
                else {
                    cc.GreenOnions = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Tortilla Strips button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveTortillaStripsClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is CowpokeChili cc) {
                if (cc.TortillaStrips == true) {
                    cc.TortillaStrips = false;
                }
                else {
                    cc.TortillaStrips = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Lettuce button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveLettuceClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Lettuce == true) {
                    ddb.Lettuce = false;
                }
                else {
                    ddb.Lettuce = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Lettuce == true) {
                    ttb.Lettuce = false;
                }
                else {
                    ttb.Lettuce = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Bun button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveBunClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Bun == true) {
                    ddb.Bun = false;
                }
                else {
                    ddb.Bun = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Bun == true) {
                    ttb.Bun = false;
                }
                else {
                    ttb.Bun = true;
                }
            }
            else if (CurrentEntree is TrailBurger tb) {
                if (tb.Bun == true) {
                    tb.Bun = false;
                }
                else {
                    tb.Bun = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Ketchup button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveKetchupClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Ketchup == true) {
                    ddb.Ketchup = false;
                }
                else {
                    ddb.Ketchup = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Ketchup == true) {
                    ttb.Ketchup = false;
                }
                else {
                    ttb.Ketchup = true;
                }
            }
            else if (CurrentEntree is TrailBurger tb) {
                if (tb.Ketchup == true) {
                    tb.Ketchup = false;
                }
                else {
                    tb.Ketchup = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Mustard button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveMustardClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Mustard == true) {
                    ddb.Mustard = false;
                }
                else {
                    ddb.Mustard = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Mustard == true) {
                    ttb.Mustard = false;
                }
                else {
                    ttb.Mustard = true;
                }
            }
            else if (CurrentEntree is TrailBurger tb) {
                if (tb.Mustard == true) {
                    tb.Mustard = false;
                }
                else {
                    tb.Mustard = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Tomato button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveTomatoClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Tomato == true) {
                    ddb.Tomato = false;
                }
                else {
                    ddb.Tomato = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Tomato == true) {
                    ttb.Tomato = false;
                }
                else {
                    ttb.Tomato = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Mayo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveMayoClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is DakotaDoubleBurger ddb) {
                if (ddb.Mayo == true) {
                    ddb.Mayo = false;
                }
                else {
                    ddb.Mayo = true;
                }
            }
            else if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Mayo == true) {
                    ttb.Mayo = false;
                }
                else {
                    ttb.Mayo = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Tomato button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveBaconClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Bacon == true) {
                    ttb.Bacon = false;
                }
                else {
                    ttb.Bacon = true;
                }
            }
        }

        /// <summary>
        /// Creates a click event for the Tomato button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddRemoveEggClicked(object sender, RoutedEventArgs e) {
            if (CurrentEntree is TexasTripleBurger ttb) {
                if (ttb.Egg == true) {
                    ttb.Egg = false;
                }
                else {
                    ttb.Egg = true;
                }
            }
        }
    }
}
