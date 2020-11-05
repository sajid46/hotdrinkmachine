using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using HotdrinkMachine.Models;
using System.ComponentModel.Design;
using System.Linq.Expressions;
using HotdrinkMachine.Repositories.DataModel;

namespace HotdrinkMachine.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string buildDrinkPrepare;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Coffee drink = new Coffee();
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine();

            // Act
            var result = hotDrinkMachine.PrepareHotDrink(drink);
            return View(result);
        }

        [HttpGet("/Home/GetDrink")]
        public string GetDrink(string drinkType)
        {
            HotDrinkMachine hotDrinkMachine = new HotDrinkMachine();
            buildDrinkPrepare += "<div class='css-drinkProgress blink_me'>You drink is being prepared</div>"; ;
            switch (drinkType.ToUpper())
            {
                case "COFFEE":
                    Coffee coffee  = new Coffee();
                    if (hotDrinkMachine.PrepareHotDrink(coffee) != null && hotDrinkMachine.PrepareHotDrink(coffee).Count > 0)
                    {
                        buildDrinkPrepare = "<div id='1' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(coffee)[0].BoilWater + "</label></div>";
                        buildDrinkPrepare += "<div id='2' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(coffee)[0].BrewCoffeeGrounds + "</label></div>";
                        buildDrinkPrepare += "<div id='3' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(coffee)[0].PourCoffeeInCup + "</label></div>";
                        buildDrinkPrepare += "<div id='4' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(coffee)[0].AddSugarAndMilk + "</label></div>";
                    }
                    break;
                case "LEMONTEA":
                    LemonTea lemontea = new LemonTea();
                    if (hotDrinkMachine.PrepareHotDrink(lemontea) != null && hotDrinkMachine.PrepareHotDrink(lemontea).Count > 0)
                    {
                        buildDrinkPrepare = "<div id='1' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(lemontea)[0].BoilWater + "</label></div>";
                        buildDrinkPrepare += "<div id='2' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(lemontea)[0].SteepWaterInTea + "</label></div>";
                        buildDrinkPrepare += "<div id='3' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(lemontea)[0].PourTeaInCup + "</label></div>";
                        buildDrinkPrepare += "<div id='4' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(lemontea)[0].AddLemon + "</label></div>";
                    }
                    break;
                case "CHOCOLATE":
                    Chocolate chocolate = new Chocolate();
                    if (hotDrinkMachine.PrepareHotDrink(chocolate) != null && hotDrinkMachine.PrepareHotDrink(chocolate).Count > 0)
                    {
                        buildDrinkPrepare = "<div id='1' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(chocolate)[0].BoilWater + "</label></div>";
                        buildDrinkPrepare += "<div id='2' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(chocolate)[0].AddChocPowderInWater + "</label></div>";
                        buildDrinkPrepare += "<div id='3' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(chocolate)[0].PourChocolateInTheCup + "</label></div>";
                    }
                    break;
                case "ROOHAFZA":
                    RoohAfza roohAfza = new RoohAfza();
                    if (hotDrinkMachine.PrepareHotDrink(roohAfza) != null && hotDrinkMachine.PrepareHotDrink(roohAfza).Count > 0)
                    {
                        buildDrinkPrepare = "<div id='1' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(roohAfza)[0].PourWaterInGlass + "</label></div>";
                        buildDrinkPrepare += "<div id='2' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(roohAfza)[0].PourRoofAfza + "</label></div>";
                        buildDrinkPrepare += "<div id='3' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(roohAfza)[0].AddIceCubes + "</label></div>";
                        buildDrinkPrepare += "<div id='4' class='css-drinkProgress '><label class='blink_me'>" + hotDrinkMachine.PrepareHotDrink(roohAfza)[0].StirItWell + "</label></div>";
                    }
                    break;
                default: return "<div class='css-drinkProgress blink_me'>No Drink Found</div>";
            }
            return buildDrinkPrepare += "<div id='ready' class='css-drinkProgress css-drinkProgress-drinkready' onclick='fn_drinkReady()'>You drink is Ready - Please Cick Here to Remove Your Drink</div>";
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
