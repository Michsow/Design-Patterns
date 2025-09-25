using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern.Beverages
{
    internal class Espresso : Beverage
    {
        public Espresso (Beverage beverage = null)
        {
            description = "Espresso";
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
    }
}
