using System;
using Xunit;
using DinoDiner.Menu;
using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace MenuTest
{
    public class OrderTest
    {
        [Fact]
        public void DefaultListShouldBeEmpty()
        {
            Order o = new Order();
            Assert.Empty(o.Items);
        }

        [Fact]
        public void DefaultSubtotalShouldBeZero()
        {
            Order o = new Order();
            Assert.Equal(0, o.SubtotalCost);
        }

        [Fact]
        public void DefaultTaxRateShouldBeZero()
        {
            Order o = new Order();
            Assert.Equal(0, o.SalesTaxRate);
        }

        [Fact]
        public void PlacingOrderItemsShouldReturnCorrectSubtotal()
        {
            Order o = new Order();
            o.Items = new ObservableCollection<IOrderItem>() { new Fryceritops(), new Sodasaurus(), new Brontowurst() };
            Assert.Equal(7.85, o.SubtotalCost, 2);
        }

        [Fact]
        public void SubTotalShouldntBeNegative()
        {
            Order o = new Order();
            Side side = new Fryceritops();
            side.Price = -5.82;
            o.Items.Add(side);
            Assert.Equal(0, o.SubtotalCost);
        }

    }
}