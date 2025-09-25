using DecoratorPattern.Beverages;
using DecoratorPattern.Factories;
using static DecoratorPattern.Factories.BeverageFactory;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] beverageNames =
            {
                "Espresso",
                "Doppio",
                "Lungo",
                "Macchiato",
                "Corretta",
                "ConPanna",
                "Cappuccino",
                "Americano",
                "CaffeLatte",
                "FlatWhite",
                "Romana",
                "Morocchino",
                "Mocha",
                "Bicerin",
                "Breve",
                "RafCoffee",
                "MeadRaf",
                "Galao",
                "CaffeAffogato",
                "ViennaCoffee",
                "Glace",
                "ChocolateMilk",
                "DemiCreme",
                "LatteMacchiato",
                "Freddo",
                "Frappuccino",
                "CaramelFrappuccino",
                "Frappe",
                "IrishCoffee"
            };

            // string = enumeration

            // Test each drink in all sizes
            foreach (var name in beverageNames)
            {
                foreach (Size size in Enum.GetValues(typeof(Size)))
                {
                    try
                    {
                        Beverage beverage = BeverageFactory.CreateBeverageByName(name);
                        beverage.Size = size;
                        PrintBeverage(name, beverage);
                        // printbeverage naar bevaragefactory ; Size eerder
                    }
                    catch (Exception ex)
                    {
                        Console.WriteLine($"Failed to create {name} ({size}): {ex.Message}");
                    }
                }
                Console.WriteLine(new string('-', 50));
            }
        }

        static void PrintBeverage(string name, Beverage beverage)
        {
            Console.WriteLine($"{beverage.Size} {name}: {beverage.GetDescription()} -> ${beverage.cost():0.00}");
        }
    }
}
