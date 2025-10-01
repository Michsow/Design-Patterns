using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;

namespace DecoratorPattern.Factories
{
    internal abstract class BeverageFactory
    {
        public abstract Beverage CreateBeverage();

        public static Beverage CreateBeverageByName(string name, Size size)
        {
            var beverage = name switch
            {
                "Espresso" => new Espresso(),
                "Doppio" => new Espresso(new Espresso()),
                "Lungo" => new Espresso(new Water()),
                "Macchiato" => new Espresso(new Milk_Foam()),
                "Corretta" => new Espresso(new Liquor()),
                "ConPanna" => new Espresso(new Whip()),
                "Cappuccino" => new Espresso(new Steamed_milk(new Milk_Foam())),
                "Americano" => new Espresso(new Water()),
                "CaffeLatte" => new Espresso(new Steamed_milk(new Steamed_milk(new Milk_Foam()))),
                "FlatWhite" => new Espresso(new Steamed_milk(new Steamed_milk())),
                "Romana" => new Espresso(new Lemon()),
                "Morocchino" => new Espresso(new Chocolate(new Milk_Foam())),
                "Mocha" => new MochaFactory().CreateBeverage(),
                "Bicerin" => new BicerinFactory().CreateBeverage(),
                "Breve" => new BreveFactory().CreateBeverage(),
                "RafCoffee" => new RafCoffeeFactory().CreateBeverage(),
                "MeadRaf" => new MeadRafFactory().CreateBeverage(),
                "Galao" => new GalaoFactory().CreateBeverage(),
                "CaffeAffogato" => new CaffeAffogatoFactory().CreateBeverage(),
                "ViennaCoffee" => new ViennaCoffeeFactory().CreateBeverage(),
                "Glace" => new GlaceFactory().CreateBeverage(),
                "ChocolateMilk" => new ChocolateMilkFactory().CreateBeverage(),
                "DemiCreme" => new DemiCremeFactory().CreateBeverage(),
                "LatteMacchiato" => new LatteMacchiatoFactory().CreateBeverage(),
                "Freddo" => new FreddoFactory().CreateBeverage(),
                "Frappuccino" => new FrappuccinoFactory().CreateBeverage(),
                "CaramelFrappuccino" => new CaramelFrappuccinoFactory().CreateBeverage(),
                "Frappe" => new FrappeFactory().CreateBeverage(),
                "IrishCoffee" => new IrishCoffeeFactory().CreateBeverage(),
                _ => throw new ArgumentException("Unknown beverage name")
            };
            beverage.Size = size;
            return beverage;
        }
        // 


        // === FACTORY CLASSES ===

    
        public class DoppioFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage doppio = new Espresso();
                doppio = new Espresso(doppio);
                return doppio;
            }
        }

        public class LungoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage lungo = new Espresso();
                lungo = new Water(lungo);
                return lungo;
            }
        }

        public class MacchiatoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage macchiato = new Espresso();
                macchiato = new Milk_Foam(macchiato);
                return macchiato;
            }
        }

        public class CorrettaFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage corretta = new Espresso();
                corretta = new Liquor(corretta);
                return corretta;
            }
        }

        public class ConPannaFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage conPanna = new Espresso();
                conPanna = new Whip(conPanna);
                return conPanna;
            }
        }

        public class CappuccinoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage cappuccino = new Espresso();
                cappuccino = new Steamed_milk(cappuccino);
                cappuccino = new Milk_Foam(cappuccino);
                return cappuccino;
            }
        }

        public class AmericanoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage americano = new Espresso();
                americano = new Water(americano);
                return americano;
            }
        }

        public class CaffeLatteFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage latte = new Espresso();
                latte = new Steamed_milk(latte);
                latte = new Steamed_milk(latte);
                latte = new Milk_Foam(latte);
                return latte;
            }
        }

        public class FlatWhiteFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage flatWhite = new Espresso();
                flatWhite = new Steamed_milk(flatWhite);
                flatWhite = new Steamed_milk(flatWhite);
                return flatWhite;
            }
        }

        public class RomanaFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage romana = new Espresso();
                romana = new Lemon(romana);
                return romana;
            }
        }

        public class MorocchinoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage morocchino = new Espresso();
                morocchino = new Chocolate(morocchino);
                morocchino = new Milk_Foam(morocchino);
                return morocchino;
            }
        }

        public class MochaFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage mocha = new Espresso();
                mocha = new Chocolate(mocha);
                mocha = new Steamed_milk(mocha);
                mocha = new Whip(mocha);
                return mocha;
            }
        }

        public class BicerinFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage bicerin = new Espresso();
                bicerin = new Black_chocolate(bicerin);
                bicerin = new White_Chocolate(bicerin);
                bicerin = new Whip(bicerin);
                return bicerin;
            }
        }

        public class BreveFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage breve = new Espresso();
                breve = new Milk_Foam(breve);
                breve = new Half_Milk(breve);
                return breve;
            }
        }

        public class RafCoffeeFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage raf = new Espresso();
                raf = new Vanilla_Sugar(raf);
                raf = new Cream(raf);
                return raf;
            }
        }

        public class MeadRafFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage meadRaf = new Espresso();
                meadRaf = new Honey(meadRaf);
                meadRaf = new Cream(meadRaf);
                return meadRaf;
            }
        }

        public class GalaoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage galao = new Espresso();
                galao = new Milk_Foam(galao);
                galao = new Milk_Foam(galao);
                return galao;
            }
        }

        public class CaffeAffogatoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage affogato = new Espresso();
                affogato = new Espresso(affogato);
                affogato = new Ice_cream(affogato);
                return affogato;
            }
        }

        public class ViennaCoffeeFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage vienna = new Espresso();
                vienna = new Espresso(vienna);
                vienna = new Whip(vienna);
                vienna = new Whip(vienna);
                return vienna;
            }
        }

        public class GlaceFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage glace = new Espresso();
                glace = new Ice_cream(glace);
                return glace;
            }
        }

        public class ChocolateMilkFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage chocMilk = new Chocolate();
                chocMilk = new Milk(chocMilk);
                chocMilk = new Milk(chocMilk);
                return chocMilk;
            }
        }

        public class DemiCremeFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage demi = new Espresso();
                demi = new Espresso(demi);
                demi = new Cream(demi);
                demi = new Cream(demi);
                return demi;
            }
        }

        public class LatteMacchiatoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage latteMac = new Espresso();
                latteMac = new Steamed_milk(latteMac);
                latteMac = new Steamed_milk(latteMac);
                latteMac = new Milk_Foam(latteMac);
                return latteMac;
            }
        }

        public class FreddoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage freddo = new Espresso();
                freddo = new Liquor(freddo);
                freddo = new Ice(freddo);
                return freddo;
            }
        }

        public class FrappuccinoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage frap = new Espresso();
                frap = new Ice(frap);
                frap = new Steamed_milk(frap);
                frap = new Whip(frap);
                return frap;
            }
        }

        public class CaramelFrappuccinoFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage caramelFrap = new Espresso();
                caramelFrap = new Ice(caramelFrap);
                caramelFrap = new Steamed_milk(caramelFrap);
                caramelFrap = new Cream(caramelFrap);
                caramelFrap = new Syrup(caramelFrap);
                return caramelFrap;
            }
        }

        public class FrappeFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage frappe = new Espresso();
                frappe = new Steamed_milk(frappe);
                frappe = new Steamed_milk(frappe);
                frappe = new Ice_cream(frappe);
                frappe = new Syrup(frappe);
                return frappe;
            }
        }

        public class IrishCoffeeFactory : BeverageFactory
        {
            public override Beverage CreateBeverage()
            {
                Beverage irishCoffee = new Espresso();
                irishCoffee = new Espresso(irishCoffee);
                irishCoffee = new Whiskey(irishCoffee);
                irishCoffee = new Whip(irishCoffee);
                return irishCoffee;
            }
        }
    }
}
