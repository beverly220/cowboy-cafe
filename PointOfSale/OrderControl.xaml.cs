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
        /// Creates a click event for the Angry Chicken button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddAngryChickenClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new AngryChicken());
        }

        /// <summary>
        /// Creates a click event for the Baked Beans button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddBakedBeansClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new BakedBeans());
        }

        /// <summary>
        /// Creates a click event for the Chili Cheese Fries button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new ChiliCheeseFries());
        }

        /// <summary>
        /// Creates a click event for the Corn Dodgers button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCornDodgersClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CornDodgers());
        }

        /// <summary>
        /// Creates a click event for the Cowboy Coffee button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CowboyCoffee());
        }

        /// <summary>
        /// Creates a click event for the Cowpoke Chili button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowpokeChiliClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CowpokeChili());
        }

        /// <summary>
        /// Creates a click event for the Dakota Double Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new DakotaDoubleBurger());
        }

        /// <summary>
        /// Creates a click event for the Jerked Soda button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new JerkedSoda());
        }

        /// <summary>
        /// Creates a click event for the Pan de Campo button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new PanDeCampo());
        }

        /// <summary>
        /// Creates a click event for the Pecos Pulled Pork button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new PecosPulledPork());
        }

        /// <summary>
        /// Creates a click event for the Rustler's Ribs button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new RustlersRibs());
        }

        /// <summary>
        /// Creates a click event for the Texas Tea button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTeaClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TexasTea());
        }

        /// <summary>
        /// Creates a click event for the Texas Triple Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TexasTripleBurger());
        }

        /// <summary>
        /// Creates a click event for the Trail Burger button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTrailburgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TrailBurger());
        }

        /// <summary>
        /// Creates a click event for the Water button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddWaterClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new Water());
        }

    }
}
