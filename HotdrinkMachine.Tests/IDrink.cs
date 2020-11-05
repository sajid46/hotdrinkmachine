using Microsoft.VisualBasic.CompilerServices;
using System.Collections.Generic;
using System.Text;

namespace HotdrinkMachine.Tests
{
     interface IDrink
    {
         string BoilWater();
         string BrewCoffeeGrounds();
         string PourDrinkInCup();
         string AddSugarAndMilk();
         string AddLemon();
         string ChocPowderInWater();
         string SteepWaterInTea();
         List<string> PrepareDrink();
    }
}