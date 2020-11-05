using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotdrinkMachine.Tests
{
    public class Coffee : IDrink
    {
        public string BoilWater()
        {
            return "Boiling water.";
        }
        public string BrewCoffeeGrounds()
        {
            return "Brewing the coffee grounds.";
        }
        public string PourDrinkInCup()
        {
            return "Pouring coffee in the cup.";
        }
        public string AddSugarAndMilk()
        {
            return "Adding Milk & Sugar.";
        }
        public string AddLemon()
        {
            return null;
        }
        public string ChocPowderInWater()
        {
            return null;
        }
        public string SteepWaterInTea()
        {
            return null;
        }
        public List<string> PrepareDrink()
        {
            List<string> drinks = new List<string>();
            drinks.Add(BoilWater());
            drinks.Add(BrewCoffeeGrounds());
            drinks.Add( PourDrinkInCup());
            drinks.Add( AddSugarAndMilk());
            return drinks;
        }


        //public List<string> PrepareDrink()
        //{
        //    List<string> lstDrinks = new List<string>();
        //    lstDrinks.Add(BoilWater());
        //    lstDrinks.Add(BrewCoffeeGrounds());
        //    lstDrinks.Add(SteepWaterInTea());
        //    lstDrinks.Add(PourDrinkInCup());
        //    lstDrinks.Add(AddSugarAndMilk());
        //    lstDrinks.Add(ChocPowderInWater());
        //    lstDrinks.Add(AddLemon());
        //    lstDrinks = lstDrinks.Where(d => d != null).ToList();
        //    return lstDrinks;
        //}
    }

    public class LemonTea : IDrink
    {
        public string BoilWater()
        {
            return "Boiling water.";
        }
        public string SteepWaterInTea()
        {
            return "Steeping water in the tea.";
        }
        public string PourDrinkInCup()
        {
            return "Pouring tea in the cup.";
        }
        public string AddLemon()
        {
            return "Adding lemon.";
        }
        public string AddSugarAndMilk()
        {
            return null;
        }
        public string BrewCoffeeGrounds()
        {
            return null;
        }
        public string ChocPowderInWater()
        {
            return null;
        }
        public List<string> PrepareDrink()
        {
            List<string> drinks = new List<string>();
            drinks.Add(BoilWater());
            drinks.Add(SteepWaterInTea());
            drinks.Add(PourDrinkInCup());
            drinks.Add(AddLemon());
            return drinks;
        }
    }

    public class Chocolate : IDrink
    {

        public string BoilWater()
        {
            return "Boiling water.";
        }
        public string PourDrinkInCup()
        {
            return "Pouring chocolate in the cup.";
        }
        public string ChocPowderInWater()
        {
            return "Add drinking chocolate powder to the water.";
        }
        public string AddLemon()
        {
            return null;
        }
        public string AddSugarAndMilk()
        {
            return null;
        }
        public string BrewCoffeeGrounds()
        {
            return null;
        }
        public string SteepWaterInTea()
        {
            return null;
        }
        public List<string> PrepareDrink()
        {
            List<string> drinks = new List<string>();
            drinks.Add(BoilWater());
            drinks.Add(ChocPowderInWater());
            drinks.Add(PourDrinkInCup());
            return drinks;
        }
    }

    internal class HotDrinkMachine 
    {
        private IDrink _drink;

        public HotDrinkMachine(IDrink drink)
        {
            _drink = drink;
        }

        internal List<string> PrepareHotDrink()
        {
            return _drink.PrepareDrink();
        }
    }


}