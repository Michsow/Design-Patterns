namespace DecoratorPattern.Beverages
{
    enum Size
    {
        TALL,
        GRANDE,
        VENDI
    }

    internal abstract class Beverage
    {
        protected string description = "Unknown";
        protected Beverage baseBeverage = null;

        // Default size if nothing is set
        private Size size = Size.TALL;

        public virtual Size Size
        {
            get
            {
                // If wrapped, inherit size from base beverage
                return baseBeverage?.Size ?? size;
            }
            set
            {
                if (baseBeverage != null)
                {
                    baseBeverage.Size = value;
                }
                else
                {
                    size = value;
                }
            }
        }

        public virtual string GetDescription()
        {
            return description;
        }

        public abstract double cost();
    }
}
