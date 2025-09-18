using DecoratorPattern.Beverages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Condiments
{
    internal class Ice_cream : CondimentDecorator
    {
        public Ice_cream(Beverage beverage)
    {
        this.baseBeverage = beverage;
    }

        public override double cost()
        {
            double extraCost = 0.20;
            switch (Size)
            {
                case Size.TALL:
                    extraCost += 0.20;
                    break;
                case Size.GRANDE:
                    extraCost += 0.40;
                    break;
                case Size.VENDI:
                    extraCost += 0.60;
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
        return baseBeverage.GetDescription() + ", Ice cream ";
    }
}
}
