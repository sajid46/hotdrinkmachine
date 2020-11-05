using System;
using Xunit;

namespace HotdrinkMachine.Tests
{
    public class UnitTest1
    {
        public UnitTest1()
        {
        }
        [Fact]
        public void PrepareDrink_Coffee()
        {
            // Arrange
            Coffee drink = new Coffee();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine(drink);
            
            // Act
            var result = hotDrinkMachine.PrepareHotDrink();

            // Assert
            Assert.Contains("Boiling water.", result);
            Assert.Contains("Brewing the coffee grounds.", result);
            Assert.Contains("Pouring coffee in the cup.", result);

        }
        [Fact]
        public void PrepareDrink_Tea()
        {
            // Arrange
            LemonTea drink = new LemonTea();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine(drink);

            // Act
            var result = hotDrinkMachine.PrepareHotDrink();

            // Assert
            Assert.Contains("Boiling water.", result);
            Assert.Contains("Steeping water in the tea.", result);
            Assert.Contains("Pouring tea in the cup.", result);
            Assert.Contains("Adding lemon.", result);

        }
        [Fact]
        public void PrepareDrink_Chocolate()
        {
            // Arrange
            Chocolate drink = new Chocolate();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine(drink);

            // Act
            var result = hotDrinkMachine.PrepareHotDrink();

            // Assert
            Assert.Contains("Boiling water.", result);
            Assert.Contains("Add drinking chocolate powder to the water.", result);
            Assert.Contains("Pouring chocolate in the cup.", result);

        }
    }
}
