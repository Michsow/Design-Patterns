using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;

namespace DecoratorPattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Espresso
            Beverage espresso = new Espresso();
            PrintBeverage(espresso);

            // Doppio
            Beverage doppio = new Espresso();
            doppio = new Espresso(doppio);
            PrintBeverage(doppio);

            // Lungo
            Beverage lungo = new Espresso();
            lungo = new Water(lungo);
            PrintBeverage(lungo);

            // Macchiato
            Beverage macchiato = new Espresso();
            macchiato = new Milk_Foam(macchiato);
            PrintBeverage(macchiato);

            // Coretta
            Beverage coretta = new Espresso();
            coretta = new Liquor(coretta);
            PrintBeverage(coretta);

            // Con Panna
            Beverage conPanna = new Espresso();
            conPanna = new Whip(conPanna);
            PrintBeverage(conPanna);

            // Cappuccino
            Beverage cappuccino = new Espresso();
            cappuccino = new Steamed_milk(cappuccino);
            cappuccino = new Milk_Foam(cappuccino);
            PrintBeverage(cappuccino);

            // Americano
            Beverage americano = new Espresso();
            americano = new Water(americano);
            americano = new Water(americano);
            PrintBeverage(americano);

            // Caffé Latte
            Beverage caffeLatte = new Espresso();
            caffeLatte = new Steamed_milk(caffeLatte);
            caffeLatte = new Steamed_milk(caffeLatte);
            caffeLatte = new Milk_Foam(caffeLatte);
            PrintBeverage(caffeLatte);

            // Flat White
            Beverage flatWhite = new Espresso();
            flatWhite = new Steamed_milk(flatWhite);
            flatWhite = new Steamed_milk(flatWhite);
            PrintBeverage(flatWhite);

            // Romana
            Beverage romana = new Espresso();
            romana = new Lemon(romana);
            PrintBeverage(romana);

            // Marocchino
            Beverage marocchino = new Espresso();
            marocchino = new Chocolate(marocchino);
            marocchino = new Milk_Foam(marocchino);
            PrintBeverage(marocchino);

            // Mocha
            Beverage mocha = new Espresso();
            mocha = new Chocolate(mocha);
            mocha = new Steamed_milk(mocha);
            mocha = new Whip(mocha);
            PrintBeverage(mocha);

            // Bicerin
            Beverage bicerin = new Espresso();
            bicerin = new Black_chocolate(bicerin);
            bicerin = new White_Chocolate(bicerin);
            bicerin = new Whip(bicerin);
            PrintBeverage(bicerin);

            // Breve
            Beverage breve = new Espresso();
            breve = new Milk_Foam(breve);
            breve = new Half_Milk(breve);
            PrintBeverage(breve);

            // Raf coffee
            Beverage rafCoffee = new Espresso();
            rafCoffee = new Vanilla_Sugar(rafCoffee);
            rafCoffee = new Cream(rafCoffee);
            PrintBeverage(rafCoffee);

            // Mead Raf
            Beverage meadRaf = new Espresso();
            meadRaf = new Honey(meadRaf);
            meadRaf = new Cream(meadRaf);
            PrintBeverage(meadRaf);

            // Galao
            Beverage galao = new Espresso();
            galao = new Milk_Foam(galao);
            galao = new Milk_Foam(galao);
            PrintBeverage(galao);

            // Caffé Affogato
            Beverage caffeAffogato = new Espresso();
            caffeAffogato = new Espresso(caffeAffogato);
            caffeAffogato = new Ice_cream(caffeAffogato);
            PrintBeverage(caffeAffogato);

            // Vienna Coffee
            Beverage viennaCoffee = new Espresso();
            viennaCoffee = new Espresso(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            viennaCoffee = new Whip(viennaCoffee);
            PrintBeverage(viennaCoffee);

            // Glace
            Beverage glace = new Espresso();
            glace = new Ice_cream(glace);
            PrintBeverage(glace);

            // Chocolate Milk
            Beverage chocolateMilk = new Chocolate();
            chocolateMilk = new Milk(chocolateMilk);
            chocolateMilk = new Milk(chocolateMilk);
            PrintBeverage(chocolateMilk);

            // Demi-crème
            Beverage demiCreme = new Espresso();
            demiCreme = new Cream(demiCreme);
            demiCreme = new Cream(demiCreme);
            PrintBeverage(demiCreme);

            // Latte Macchiato
            Beverage latteMacchiato = new Espresso();
            latteMacchiato = new Steamed_milk(latteMacchiato);
            latteMacchiato = new Steamed_milk(latteMacchiato);
            latteMacchiato = new Milk_Foam(latteMacchiato);
            PrintBeverage(latteMacchiato);

            // Freddo
            Beverage freddo = new Espresso();
            freddo = new Liquor(freddo);
            freddo = new Ice(freddo);
            PrintBeverage(freddo);

            // Frappuccino
            Beverage frappuccino = new Espresso();
            frappuccino = new Ice(frappuccino);
            frappuccino = new Steamed_milk(frappuccino);
            frappuccino = new Whip(frappuccino);
            PrintBeverage(frappuccino);

            // Caramel Frappuccino
            Beverage caramelFrappuccino = new Espresso();
            caramelFrappuccino = new Ice(caramelFrappuccino);
            caramelFrappuccino = new Steamed_milk(caramelFrappuccino);
            caramelFrappuccino = new Cream(caramelFrappuccino);
            caramelFrappuccino = new Syrup(caramelFrappuccino);
            PrintBeverage(caramelFrappuccino);

            // Frappe
            Beverage frappe = new Espresso();
            frappe = new Steamed_milk(frappe);
            frappe = new Steamed_milk(frappe);
            frappe = new Ice_cream(frappe);
            PrintBeverage(frappe);

            // Irish Coffee
            Beverage irishCoffee = new Espresso();
            irishCoffee = new Espresso(irishCoffee);
            irishCoffee = new Whiskey(irishCoffee);
            irishCoffee = new Whip(irishCoffee);
            PrintBeverage(irishCoffee);
        }

        static void PrintBeverage(Beverage beverage)
        {
            Console.WriteLine(beverage.GetDescription() + " $" + beverage.cost().ToString("#.##"));
        }
    }
}
