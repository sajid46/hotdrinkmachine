using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HotdrinkMachine.Tests
{
    public class Coffee : IDrink<CoffeeModel>
    {
        private List<CoffeeModel> _drinkModel;

        public List<CoffeeModel> DrinkInProcess
        {
            get
            {
                return _drinkModel;
            }
            set
            {
                _drinkModel = value;
            }
        }

        public List<CoffeeModel> PrepareDrink()
        {
            List<CoffeeModel> drinks = new List<CoffeeModel>();
            var drink = new CoffeeModel();
            drink.BoilWater = "Boiling water";
            drink.BrewCoffeeGrounds = "Brewing the coffee grounds";
            drink.PourCoffeeInCup = "Pouring coffee in the cup";
            drink.AddSugarAndMilk = "Adding sugar and milk";
            drinks.Add(drink);
            return drinks;
        }
    }

    public class LemonTea : IDrink<LemonTeaModel>
    {
        private List<LemonTeaModel> _drinkModel;

        public List<LemonTeaModel> DrinkInProcess
        {
            get
            {
                return _drinkModel;
            }
            set
            {
                _drinkModel = value;
            }
        }

        public List<LemonTeaModel> PrepareDrink()
        {
            List<LemonTeaModel> drinks = new List<LemonTeaModel>();
            LemonTeaModel drink = new LemonTeaModel();
            drink.BoilWater = "Boiling water";
            drink.SteepWaterInTea = "Steeping water in the tea";
            drink.PourTeaInCup = "Pouring tea in the cup";
            drink.AddLemon = "Adding lemon";
            drinks.Add(drink);
            return drinks;
        }
    }

    public class Chocolate : IDrink<ChocolateModel>
    {
        private List<ChocolateModel> _drinkModel;

        public List<ChocolateModel> DrinkInProcess
        {
            get
            {
                return _drinkModel;
            }
            set
            {
                _drinkModel = value;
            }
        }

        public List<ChocolateModel> PrepareDrink()
        {
            List<ChocolateModel> drinks = new List<ChocolateModel>();
            var drink = new ChocolateModel();
            drink.BoilWater = "Boiling water";
            drink.AddChocPowderInWater = "Add drinking chocolate powder to the water";
            drink.PourChocolateInTheCup = "Pouring chocolate in the cup";
            drinks.Add(drink);
            return drinks;
        }
    }


    internal class HotDrinkMachine
    {
    
        //public HotDrinkMachine(IDrink<T> drink)
        //{
        //    _drink = drink;
        //}

        internal List<T> PrepareHotDrink<T>(IDrink<T> drink)
        {
            return drink.PrepareDrink();
        }
    }


}