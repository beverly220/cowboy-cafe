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
        public DontDeleteControl() {
            InitializeComponent();
            if (DataContext is Order o) {
                StillDue = o.Subtotal;
            }
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
        public double StillDue { get; set; }

        /// <summary>
        /// Subtotal still owed
        /// </summary>
        private double AmountGiven { get; set; } = 0;

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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                MessageBox.Show("Customer gave exact amount, no change due", "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
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
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
            else if (StillDue < 0) {
                AdjustDrawer();
                StillDue *= -1.0;
                MessageBox.Show("Customer was dispensed " + StillDue.ToString("#.00") + " below and drawer has adjusted accordingly",
                    "Change Due", MessageBoxButton.OK);
                ReceiptPrinter receipt = new ReceiptPrinter();
                if (DataContext is Order o) {
                    receipt.Print(o.ToString(AmountGiven));
                }
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
                orderControl.Stupid();
                orderControl.SwapScreen(new OrderSummaryControl());
            }
        }
    }
}
