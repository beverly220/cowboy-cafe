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
    /// Interaction logic for DontDeleteControl.xaml
    /// </summary>
    public partial class DontDeleteControl : UserControl {
        public DontDeleteControl(double total) {
            InitializeComponent();
            StillDue = total;
            AddPenny.Click += OnAddPennyClicked;
            AddNickel.Click += OnAddNickelClicked;
            AddDime.Click += OnAddDimeClicked;
            AddQuarter.Click += OnAddQuarterClicked;
            AddHalfDollar.Click += OnAddHalfDollarClicked;
            AddOne.Click += OnAddOneClicked;
            AddTwo.Click += OnAddTwoClicked;
            AddFive.Click += OnAddFiveClicked;
            AddTen.Click += OnAddTenClicked;
            AddTwenty.Click += OnAddTwentyClicked;
            AddFifty.Click += OnAddFiftyClicked;
            AddHundred.Click += OnAddHundredClicked;
        }

        /// <summary>
        /// Subtotal still owed
        /// </summary>
        public double StillDue { get; set; } = 234.67;

        /// <summary>
        /// Subtotal still owed
        /// </summary>
        private double AmountGiven { get; set; } = 0;

        private void AdjustDrawer(double adj) {
            var orderControl = this.FindAncestor<OrderControl>();
            while (adj < 0) {
                if (adj > 100 && orderControl.CurrentDrawer.Hundreds > 1) {
                    adj -= 100.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.Hundred, 1);
                }
                else if (adj > 50 && orderControl.CurrentDrawer.Fifties > 1) {
                    adj -= 50.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.Fifty, 1);
                }
                else if (adj > 20 && orderControl.CurrentDrawer.Twenties > 1) {
                    adj -= 20.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.Twenty, 1);
                }
                else if (adj > 10 && orderControl.CurrentDrawer.Tens > 1) {
                    adj -= 10.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.Ten, 1);
                }
                else if (adj > 5 && orderControl.CurrentDrawer.Fives > 1) {
                    adj -= 5.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.Five, 1);
                }
                else if (adj > 1 && orderControl.CurrentDrawer.Ones > 1) {
                    adj -= 1.0;
                    orderControl.CurrentDrawer.RemoveBill(Bills.One, 1);
                }
                else if (adj > .5 && orderControl.CurrentDrawer.HalfDollars > 1) {
                    adj -= .5;
                    orderControl.CurrentDrawer.RemoveCoin(Coins.HalfDollar, 1);
                }
                else if (adj > .25 && orderControl.CurrentDrawer.Quarters > 1) {
                    adj -= .25;
                    orderControl.CurrentDrawer.RemoveCoin(Coins.Quarter, 1);
                }
                else if (adj > .1 && orderControl.CurrentDrawer.Dimes > 1) {
                    adj -= .1;
                    orderControl.CurrentDrawer.RemoveCoin(Coins.Dime, 1);
                }
                else if (adj > .05 && orderControl.CurrentDrawer.Nickels > 1) {
                    adj -= .05;
                    orderControl.CurrentDrawer.RemoveCoin(Coins.Nickel, 1);
                }
                else if (adj > .1 && orderControl.CurrentDrawer.Pennies > 1) {
                    adj -= .1;
                    orderControl.CurrentDrawer.RemoveCoin(Coins.Penny, 1);
                }
                else {
                    ///Restock the drawer
                    orderControl.CurrentDrawer.AddCoin(Coins.Penny, 50);
                    orderControl.CurrentDrawer.AddCoin(Coins.Dime, 10);
                    orderControl.CurrentDrawer.AddBill(Bills.One, 25);
                    orderControl.CurrentDrawer.AddBill(Bills.Five, 10);
                }
            }
        }

        /// <summary>
        /// The amount of pennies
        /// </summary>
        public int PennyCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Pennies; 
            }
        }

        /// <summary>
        /// The amount of nickels
        /// </summary>
        public int NickelCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Nickels;
            }
        }

        /// <summary>
        /// The amount of dimes
        /// </summary>
        public int DimeCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Dimes;
            }
        }

        /// <summary>
        /// The amount of quarters
        /// </summary>
        public int QuarterCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Quarters;
            }
        }

        /// <summary>
        /// The amount of half dollars
        /// </summary>
        public int HalfDollarCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.HalfDollars;
            }
        }

        /// <summary>
        /// The amount of ones
        /// </summary>
        public int OneCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Ones;
            }
        }

        /// <summary>
        /// The amount of twos
        /// </summary>
        public int TwoCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Twos;
            }
        }

        /// <summary>
        /// The amount of fives
        /// </summary>
        public int FiveCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Fives;
            }
        }

        /// <summary>
        /// The amount of tens
        /// </summary>
        public int TenCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Tens;
            }
        }

        /// <summary>
        /// The amount of twenties
        /// </summary>
        public int TwentyCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Twenties;
            }
        }

        /// <summary>
        /// The amount of fifties
        /// </summary>
        public int FiftyCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Fifties;
            }
        }

        /// <summary>
        /// The amount of hundreds
        /// </summary>
        public int HundredCount {
            get {
                var orderControl = this.FindAncestor<OrderControl>();
                return orderControl.CurrentDrawer.Hundreds;
            }
        }

        /// <summary>
        /// Creates a click event for the Penny button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddPennyClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= .01;
            AmountGiven += .01;
            orderControl.CurrentDrawer.AddCoin(Coins.Penny, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Nickel button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddNickelClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= .05;
            AmountGiven += .05;
            orderControl.CurrentDrawer.AddCoin(Coins.Nickel, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }

        }

        /// <summary>
        /// Creates a click event for the Dime button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddDimeClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= .10;
            AmountGiven += .10;
            orderControl.CurrentDrawer.AddCoin(Coins.Dime, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Quarter button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddQuarterClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= .25;
            AmountGiven += .25;
            orderControl.CurrentDrawer.AddCoin(Coins.Quarter, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the One button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddOneClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 1.0;
            AmountGiven += 1.0;
            orderControl.CurrentDrawer.AddBill(Bills.One, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Two button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTwoClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 2.0;
            AmountGiven += 2.0;
            orderControl.CurrentDrawer.AddBill(Bills.Two, 1);
            if (StillDue == 0) {
                    orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                    StillDue *= -1.0;
                    MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                        "Change Due", MessageBoxButton.OK);
                    AdjustDrawer(StillDue);
                    orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Half Dollar button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddHalfDollarClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= .50;
            AmountGiven += .50;
            orderControl.CurrentDrawer.AddCoin(Coins.HalfDollar, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Five button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddFiveClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 5.0;
            AmountGiven += 5.0;
            orderControl.CurrentDrawer.AddBill(Bills.Five, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }

        }

        /// <summary>
        /// Creates a click event for the Ten button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTenClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 10.0;
            AmountGiven += 10.0;
            orderControl.CurrentDrawer.AddBill(Bills.Ten, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }

        }

        /// <summary>
        /// Creates a click event for the Twenty button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddTwentyClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 20.0;
            AmountGiven += 20.0;
            orderControl.CurrentDrawer.AddBill(Bills.Twenty, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the Fifty button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddFiftyClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 50.0;
            AmountGiven += 50.0;
            orderControl.CurrentDrawer.AddBill(Bills.Fifty, 1);
            if (StillDue == 0) {
                orderControl.GivenExactCash(AmountGiven);
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("0.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                AdjustDrawer(StillDue);
                orderControl.GivenMoreCash(AmountGiven);
            }
        }

        /// <summary>
        /// Creates a click event for the One button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddHundredClicked(object sender, RoutedEventArgs e) {
            var orderControl = this.FindAncestor<OrderControl>();
            StillDue -= 100.0;
            AmountGiven += 100.0;
            orderControl.CurrentDrawer.AddBill(Bills.Hundred, 1);
            if (StillDue == 0) {
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                var o = DataContext as Order;
                receipt.Print(o.ToString(AmountGiven));
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                StillDue *= -1.0;
                AdjustDrawer(StillDue);
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                var o = DataContext as Order;
                receipt.Print(o.ToString(AmountGiven));
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
        }
    }
}
