using System;
using System.Linq;
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
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine();
            

            // Act
            var result = hotDrinkMachine.PrepareHotDrink(drink);

            // Assert
            Assert.NotNull(result.Where(x => x.BoilWater == "Boiling water"));
            Assert.NotNull(result.Where(x => x.BrewCoffeeGrounds == "Brewing the coffee grounds"));
            Assert.NotNull(result.Where(x => x.PourCoffeeInCup == "Pouring coffee in the cup"));

        }
        [Fact]
        public void PrepareDrink_Tea()
        {
            // Arrange
            LemonTea drink = new LemonTea();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine();

            // Act
            var result = hotDrinkMachine.PrepareHotDrink(drink);

            // Assert
            Assert.NotNull(result.Where(x => x.BoilWater == "Boiling water"));
            Assert.NotNull(result.Where(x => x.SteepWaterInTea == "Steeping water in the tea"));
            Assert.NotNull(result.Where(x => x.PourTeaInCup == "Pouring tea in the cup"));
            Assert.NotNull(result.Where(x => x.AddLemon == "Adding lemon"));

        }
        [Fact]
        public void PrepareDrink_Chocolate()
        {
            // Arrange
            Chocolate drink = new Chocolate();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine();

            // Act
            var result = hotDrinkMachine.PrepareHotDrink(drink);

            // Assert
            Assert.NotNull(result.Where(x => x.BoilWater == "Boiling water."));
            Assert.NotNull(result.Where(x => x.AddChocPowderInWater == "Adding chocolate powder to the water"));
            Assert.NotNull(result.Where(x => x.PourChocolateInTheCup == "Pouring chocolate in the cup"));

        }
    }
}
