using DecoratorPattern.Beverages;
using DecoratorPattern.Condiments;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Factories
{
    internal class SimpleBeverageFactory
    {
        public Beverage createBeverage(String type
        {
            Beverage beverage = null;
            if (type.Equals("espresso"))
            {
                beverage = new Espresso();
            }
            else if (type.Equals("espresso"))
            {
                beverage = new Duppio();
            }
            else if (type.Equals("espresso"))
            {
                beverage = new Lungo();
            }
            else if (type.Equals("espresso"))
            {
                beverage = new Macchiato();
            }
            return beverage;

        }
    }
}
