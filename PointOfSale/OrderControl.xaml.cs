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

        public void OnAddAngryChickenClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new AngryChicken());
        }

        public void OnAddBakedBeansClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new BakedBeans());
        }

        public void OnAddChiliCheeseFriesClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new ChiliCheeseFries());
        }

        public void OnAddCornDodgersClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CornDodgers());
        }

        public void OnAddCowboyCoffeeClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CowboyCoffee());
        }

        public void OnAddCowpokeChiliClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new CowpokeChili());
        }

        public void OnAddDakotaDoubleBurgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new DakotaDoubleBurger());
        }

        public void OnAddJerkedSodaClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new JerkedSoda());
        }

        public void OnAddPanDeCampoClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new PanDeCampo());
        }

        public void OnAddPecosPulledPorkClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new PecosPulledPork());
        }

        public void OnAddRustlersRibsClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new RustlersRibs());
        }

        public void OnAddTexasTeaClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TexasTea());
        }

        public void OnAddTexasTripleBurgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TexasTripleBurger());
        }

        public void OnAddTrailburgerClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new TrailBurger());
        }

        public void OnAddWaterClicked(object sender, RoutedEventArgs e) {
            CurrentOrder.Items.Add(new Water());
        }

    }
}
