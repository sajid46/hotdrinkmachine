using System.Collections.Generic;

namespace HotdrinkMachine.Tests
{
    public interface ICoffee
    {
        string BoilWater();
        string BrewCoffeeGrounds();
        string PourCoffeeInTheCup();
        string AddSugarAndMilk();
        List<string> PrepareDrink();
    }
}