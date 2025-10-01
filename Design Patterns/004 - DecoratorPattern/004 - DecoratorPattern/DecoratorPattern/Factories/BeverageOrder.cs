using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Factories
{
    internal abstract class BeverageOrder
    {

        SimpleBeverageFactory factory;
        public BeverageOrder(SimpleBeverageFactory factory)
        {
            this.factory = factory;
        }

        public Beverage orderbeverage(String type)
        {
            
            Beverage beverage = factory.createBeverage(type);

            beverage.Beveragebase();
            beverage.Beveragecondiments();
            beverage.Size();
            beverage.Cost();
            beverage.Print();
            return beverage;

        }
    }
}
