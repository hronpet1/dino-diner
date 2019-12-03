using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;


namespace MenuTest
{
    public class ComboTest
    {

        [Fact]
        public void DefaultComboShouldHaveCorrectItems()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            Assert.IsType<Sodasaurus>(combo.Drink);
            Assert.IsType<Fryceritops>(combo.Side);
            Assert.IsType<Brontowurst>(combo.Entree);
        }

        [Fact]
        public void DefaultComboShouldHaveCorrectPrice()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            Assert.Equal(7.6, combo.Price, 2);
        }

        [Fact]
        public void CretaceousComboDescriptionShouldGiveCorrectName()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            Assert.Equal("Brontowurst Combo", combo.Description);
        }

        [Fact]
        public void DefaultSpecialsShouldBeCorrect()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            List<string> list = new List<string>() { "Small Fryceritops", "Small Cola Sodasaurus" };
            string[] str = list.ToArray();
            Assert.Equal(str, combo.Special);
        }

        [Fact]
        public void ComboShouldHaveIngredients()
        {
            CretaceousCombo combo = new CretaceousCombo(new Brontowurst());
            Assert.NotEmpty(combo.Ingredients);
        }
    }
}
