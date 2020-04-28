using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests {
    public class MenuTest {

        [Fact]
        public void ShouldHaveAllEntrees() {
            var entrees = Menu.Entrees;
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in entrees) {
                Assert.True(i is Entree);
                count++;
                contain.Add(i.ToString());
            }
            Assert.True(count == 7);
            Assert.Contains(new AngryChicken().ToString(), contain);
            Assert.Contains(new CowpokeChili().ToString(), contain);
            Assert.Contains(new DakotaDoubleBurger().ToString(), contain);
            Assert.Contains(new PecosPulledPork().ToString(), contain);
            Assert.Contains(new RustlersRibs().ToString(), contain);
            Assert.Contains(new TexasTripleBurger().ToString(), contain);
            Assert.Contains(new TrailBurger().ToString(), contain);
        }

        [Fact]
        public void ShouldHaveAllSides() {
            var sides = Menu.Sides;
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in sides) {
                Assert.True(i is Side);
                count++;
                contain.Add(i.ToString());
            }
            Assert.True(count >= 4);
            Assert.Contains(new BakedBeans().ToString(), contain);
            Assert.Contains(new ChiliCheeseFries().ToString(), contain);
            Assert.Contains(new CornDodgers().ToString(), contain);
            Assert.Contains(new PanDeCampo().ToString(), contain);
        }

        [Fact]
        public void ShouldHaveAllDrinks() {
            var drinks = Menu.Drinks;
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in drinks) {
                Assert.True(i is Drink);
                contain.Add(i.ToString());
                count++;
                contain.Add(i.ToString());
            }
            Assert.True(count >= 4);
            Assert.Contains("Medium Cowboy Coffee", contain);
            JerkedSoda js = new JerkedSoda();
            js.Flavor = SodaFlavor.BirchBeer;
            Assert.Contains(js.ToString(), contain);
            Assert.Contains("Medium Texas Sweet Tea", contain);
            Assert.Contains("Medium Water", contain);
        }

        [Fact]
        public void ShouldHaveAllItems() {
            var all = Menu.AllMenuItems;
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in all) {
                count++;
                contain.Add(i.ToString());
            }
            Assert.True(count >= 15);
            Assert.Contains(new AngryChicken().ToString(), contain);
            Assert.Contains(new CowpokeChili().ToString(), contain);
            Assert.Contains(new DakotaDoubleBurger().ToString(), contain);
            Assert.Contains(new PecosPulledPork().ToString(), contain);
            Assert.Contains(new RustlersRibs().ToString(), contain);
            Assert.Contains(new TexasTripleBurger().ToString(), contain);
            Assert.Contains(new TrailBurger().ToString(), contain);
            Assert.Contains(new BakedBeans().ToString(), contain);
            Assert.Contains(new ChiliCheeseFries().ToString(), contain);
            Assert.Contains(new CornDodgers().ToString(), contain);
            Assert.Contains(new PanDeCampo().ToString(), contain);
            Assert.Contains(new CowboyCoffee().ToString(), contain);
            JerkedSoda js = new JerkedSoda();
            js.Flavor = SodaFlavor.BirchBeer;
            Assert.Contains(js.ToString(), contain);
            Assert.Contains(new TexasTea().ToString(), contain);
            Assert.Contains(new Water().ToString(), contain);
        }

        [Fact]
        public void ShouldHaveChiSearch() {
            var test = Menu.AllMenuItems;
            Menu.Search("Chi");
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in test) {
                count++;
                contain.Add(i.ToString());
            }
            Assert.Contains(new AngryChicken().ToString(), contain);
            Assert.Contains(new CowpokeChili().ToString(), contain);
            Assert.Contains(new ChiliCheeseFries().ToString(), contain);
        }


        [Fact]
        public void ShouldHaveCorrectPriceAndCalories() {
            var test = Menu.AllMenuItems;
            Menu.FilterByPrice(test, 0, 5.0);
            Menu.FilterByCalories(test, 200, 700);
            int count = 0;
            List<string> contain = new List<string>();
            foreach (IOrderItem i in test) {
                count++;
                contain.Add(i.ToString());
            }
            Assert.True(count >= 2);
            Assert.Contains(new DakotaDoubleBurger().ToString(), contain);
            Assert.Contains(new PecosPulledPork().ToString(), contain);
        }




    }
}
