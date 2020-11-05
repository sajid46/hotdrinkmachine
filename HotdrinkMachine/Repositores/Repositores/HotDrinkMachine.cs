using HotdrinkMachine.Repositories.DataModel;
using System.Collections.Generic;

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
        drink.AddChocPowderInWater = "Adding chocolate powder to the water";
        drink.PourChocolateInTheCup = "Pouring chocolate in the cup";
        drinks.Add(drink);
        return drinks;
    }
}

public class RoohAfza : IDrink<RoohAfzaModel>
{
    private List<RoohAfzaModel> _drinkModel;

    public List<RoohAfzaModel> DrinkInProcess
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

    public List<RoohAfzaModel> PrepareDrink()
    {
        List<RoohAfzaModel> drinks = new List<RoohAfzaModel>();
        var drink = new RoohAfzaModel();
        drink.PourWaterInGlass = "Pouring water in glass";
        drink.PourRoofAfza = "Pouring Roof Afza";
        drink.AddIceCubes = "Adding ice cubes";
        drink.StirItWell = "Stirring";
        drinks.Add(drink);
        return drinks;
    }
}
internal class HotDrinkMachine
{
    internal List<T> PrepareHotDrink<T>(IDrink<T> drink)
    {
        return drink.PrepareDrink();
    }
}
