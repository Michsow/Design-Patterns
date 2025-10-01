using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Factories
{
    internal class Store1Factory
    {
        public Beverage createBeverage(String type) {
            Beverage beverage = null;
            if (type.Equals("espresso"))
            {
                beverage = new S1StyleEspresso();
            }
            else if (type.Equals("espresso"))
            {
                beverage = new S1StyleDuppio();
            }
            else if (type.Equals("espresso"))
            {
                beverage = new S1StyleLungo();
            }
            else if (type.Equals("veggie"))
            {
                beverage = new S1StyleMacchiato();
            }
            return beverage;

        }
    }
}