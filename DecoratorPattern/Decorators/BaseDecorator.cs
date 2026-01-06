using DecoratorPattern.Abstractions;

namespace DecoratorPattern.Decorators
{
    public abstract class BaseDecorator : IBeverage
    {
        protected IBeverage _beverage;

        public BaseDecorator(IBeverage beverage)
        {
            _beverage = beverage;            
        }

        public virtual double getBeverageCost()
        {
            return _beverage.getBeverageCost();
        }

        public virtual string getBeverageDescription()
        {
            return _beverage.getBeverageDescription();
        }
    }
}
