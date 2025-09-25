using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Cream : CondimentDecorator
    {
        public Cream (Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extraCost = 1.99;
            switch (Size)
            {
                case Size.TALL:
                    extraCost += 0.50;
                    break;
                case Size.GRANDE:
                    extraCost += 1.00;
                    break;
                case Size.VENDI:
                    extraCost += 1.50;
                    break;
            }

            if (baseBeverage != null)
            {
                return extraCost + baseBeverage.cost();
            }
            return extraCost;
        }

        public override string GetDescription()
        {
            return baseBeverage.GetDescription() + ", Cream ";
        }
    }
}
