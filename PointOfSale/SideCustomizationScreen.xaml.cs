using CowboyCafe.Data;
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

namespace PointOfSale {
    /// <summary>
    /// Interaction logic for SideCustomizationScreen.xaml
    /// </summary>
    public partial class SideCustomizationScreen : UserControl {
        public SideCustomizationScreen(Side side, OrderControl orderC) {
            InitializeComponent();
            CurrentSide = side;
            orderControl = orderC;
            SmallSize.Click += OnAddSmallSizeClicked;
            MediumSize.Click += OnAddMediumSizeClicked;
            LargeSize.Click += OnAddLargeSizeClicked;
        }

        /// <summary>
        /// Holds the type of side being customized
        /// </summary>
        Side CurrentSide;

        /// <summary>
        /// Holds the order control
        /// </summary>
        OrderControl orderControl;

        /// <summary>
        /// Creates a click event for the Small button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddSmallSizeClicked(object sender, RoutedEventArgs e) {
            CurrentSide.Size = CowboyCafe.Data.Size.Small;
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Creates a click event for the Medium button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddMediumSizeClicked(object sender, RoutedEventArgs e) {
            CurrentSide.Size = CowboyCafe.Data.Size.Medium;
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Creates a click event for the Large button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void OnAddLargeSizeClicked(object sender, RoutedEventArgs e) {
            CurrentSide.Size = CowboyCafe.Data.Size.Large;
            orderControl.SwapScreen(new MenuItemSelectionControl());
        }
    }

}
