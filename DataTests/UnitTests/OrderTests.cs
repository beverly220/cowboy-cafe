using CowboyCafe.Data;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace CowboyCafe.DataTests.UnitTests {

    /// <summary>
    /// Creates mock items for testing purposes
    /// </summary>
    class MockOrderItem : IOrderItem { 
        /// <summary>
        /// Stores a mock price for an item
        /// </summary>
        public override double Price { get; set; }

        /// <summary>
        /// Keeps track of special instructions
        /// for mock items
        /// </summary>
        public override List<string> SpecialInstructions { get; set; }
    }

    /// <summary>
    /// Tests to check if the Order class works
    /// </summary>
    public class OrderTests {

        /// <summary>
        /// Adding something to the order should add it
        /// to the items property
        /// </summary>
        [Fact]
        public void AddedIOrderItemsAppearInItemsProperty() {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            Assert.Contains(item, order.Items);
            //checks if memory address is the same
        }

        /// <summary>
        /// Removing something from the order should remove
        /// it from the items property
        /// </summary>
        [Fact]
        public void RemovedIOrderItemsAppearInItemsProperty() {
            var order = new Order();
            var item = new MockOrderItem();
            order.Add(item);
            order.Remove(item);
            Assert.DoesNotContain(item, order.Items);
        }

        /// <summary>
        /// The sum of the order items should be each
        /// order item added together
        /// </summary>
        [Theory]
        [InlineData(new double[] { })]
        [InlineData(new double[] { 0 })]
        [InlineData(new double[] { 10, 15, 18 })]
        [InlineData(new double[] { 20, -4, 3.6, 8 })]
        [InlineData(new double[] { -100, -5 })]
        public void SubtotalShouldBeTheSumOfOrderItemsPrices(IEnumerable<double> prices) {
            var order = new Order();
            double total = 0;
            foreach(var price in prices) {
                total += price;
                order.Add(new MockOrderItem() {
                    Price = price
                });
            }
            Assert.Equal(total, order.Subtotal);
        }

        /// <summary>
        /// Items should only contain items added to
        /// the order
        /// </summary>
        [Fact]
        public void ItemsShouldContainOnlyAddedItems() {
            var items = new IOrderItem[] {
                new MockOrderItem() {Price = 3},
                new MockOrderItem() { Price = 4 },
                 new MockOrderItem() {Price = 7}
            };
            var order = new Order();
            foreach (var item in items) {
                order.Add(item);
            }
            Assert.Equal(items.Length, order.Items.Count());
            foreach(var item in items) {
                Assert.Contains(item, order.Items);
            }
        }
    }
}
