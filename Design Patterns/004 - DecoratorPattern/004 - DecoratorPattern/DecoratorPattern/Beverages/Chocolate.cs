using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Chocolate : Beverage
    {
        public Chocolate(Beverage beverage = null)
        {
            description = "Chocolate";
            this.baseBeverage = beverage;

        }
        public override string GetDescription()
        {
            if (baseBeverage != null)
            {
                return baseBeverage.GetDescription() + ", " + description;
            }
            return description;
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
    }
}
