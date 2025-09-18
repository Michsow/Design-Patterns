using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Syrup : CondimentDecorator
    {
        public Syrup(Beverage beverage)
        {
            this.baseBeverage = beverage;
        }

        public override double cost()
        {
            double extraCost = 0.10;
            switch (Size)
            {
                case Size.TALL:
                    extraCost += 0.10;
                    break;
                case Size.GRANDE:
                    extraCost += 0.20;
                    break;
                case Size.VENDI:
                    extraCost += 0.40;
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
            return baseBeverage.GetDescription() + ", Syrup ";
        }
    }
}
